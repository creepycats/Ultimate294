using Exiled.API.Enums;
using Exiled.API.Features;
using MapEditorReborn.API.Features;
using MapEditorReborn.API.Features.Objects;
using MapEditorReborn.API.Features.Serializable;
using MapEditorReborn.Commands.ModifyingCommands.Scale;
using SCP294.Types;
using SCP294.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEC;
using UnityEngine;
using Exiled.API.Features.Pickups;
using Exiled.API.Features.Toys;
using InventorySystem.Items.Pickups;
using InventorySystem.Items;
using Exiled.API.Features.Items;
using MapEditorReborn.Commands.ModifyingCommands.Position;
using MapEditorReborn.Commands.ModifyingCommands.Rotation;

namespace SCP294.Classes
{
    public class SCP294Object
    {
        /// <summary>
        /// Coroutine that handles the hint upon approaching SCP-294
        /// </summary>
        /// <returns></returns>
        public static IEnumerator<float> Handle294Hint()
        {
            for (; ; )
            {
                yield return Timing.WaitForSeconds(0.1f);

                foreach (Player player in Player.List)
                {
                    if (player == null) continue;
                    if (player.IsNPC) continue;
                    if (CanPlayerUse294(player))
                    {
                        if (!SCP294.Instance.PlayersNear294.Contains(player.UserId)) {
                            SchematicObject scp294 = GetClosest294(player);
                            if (SCP294.Instance.SCP294UsesLeft.Keys.Contains(scp294) && SCP294.Instance.SCP294UsesLeft[scp294] == 0) {
                                player.ShowHint("<size=300>\n</size>\n<size=35>You Approach SCP-294.</size>\n<size=30>It seems to have lost all power, rendering it unusable for now...</size>", 3);
                            }
                            else
                            {
                                player.ShowHint("<size=300>\n</size>\n<size=35>You Approach SCP-294.</size>\n<size=30>If you had a coin, you could buy a drink...</size>\n<size=20>(Hold a Coin, Open Console, Use the command '.scp294 <drink>' to dispense your drink of choice)</size>", 3);
                            }
                            SCP294.Instance.PlayersNear294.Add(player.UserId);
                        }
                    }
                    else
                    {
                        if (SCP294.Instance.PlayersNear294.Contains(player.UserId))
                        {
                            SCP294.Instance.PlayersNear294.Remove(player.UserId);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Naturally Spawns Instances of SCP-294 based on Config Values
        /// </summary>
        public static void SpawnSCP294()
        {
            SCP294.Instance.SpawnedSCP294s = new Dictionary<SchematicObject, bool>();

            // Get Room and Visual
            for (int i = 0; i < SCP294.Instance.Config.SpawningLocations.SpawnAmount; i++)
            {
                Room SpawnRoom = RoomHandler.GetRandomRoom(SCP294.Instance.Config.SpawningLocations.SpawnRooms.Keys.ToList());
                if (!SpawnRoom) continue;
                SpawnTransform relativeOffsetTransform = SCP294.Instance.Config.SpawningLocations.SpawnRooms[SpawnRoom.Type].RandomItem();

                CreateSCP294(SpawnRoom.Position + (SpawnRoom.Rotation * relativeOffsetTransform.Position), Quaternion.Euler(SpawnRoom.Rotation.eulerAngles + Quaternion.Euler(relativeOffsetTransform.Rotation.X, relativeOffsetTransform.Rotation.Y, relativeOffsetTransform.Rotation.Z).eulerAngles), relativeOffsetTransform.Scale);
            }
        }

        /// <summary>
        /// Spawns an instance of SCP-294 at the given location
        /// </summary>
        public static void CreateSCP294(Vector3 Position, Quaternion Rotation, Vector3 Scale)
        {
            SchematicObject scp294 = ObjectSpawner.SpawnSchematic("scp294", Vector3.zero, Quaternion.identity, Vector3.one);
            scp294.Position = Position;
            scp294.Rotation = Rotation;
            scp294.Scale = Scale;

            // Add Illumination to Front
            Vector3 lightPos = scp294.Position;
            lightPos += scp294.Rotation * new Vector3(0f, 1.25f, -1.25f);
            SCP294.Instance.SCP294LightSources.Add(scp294,ObjectSpawner.SpawnLightSource(new LightSourceSerializable()
            {
                Color = "#FFF",
                Intensity = 0.25f,
                Shadows = true,
                Range = 1
            }, lightPos));

            // Add to 294 List
            SCP294.Instance.SpawnedSCP294s.Add(scp294, false);
            SCP294.Instance.SCP294UsesLeft.Add(scp294, SCP294.Instance.Config.MaxUsesPerMachine);
        }

        /// <summary>
        /// Destroys the nearest SCP-294 to the player
        /// </summary>
        /// <param name="scp294">Instance of SCP-294 to change</param>
        public static void RemoveSCP294(SchematicObject scp294)
        {
            if (scp294 != null && SCP294.Instance.SCP294UsesLeft.Keys.Contains(scp294))
            {
                SCP294.Instance.SpawnedSCP294s.Remove(scp294);
                SCP294.Instance.SCP294UsesLeft.Remove(scp294);
                try
                {
                    if (SCP294.Instance.SCP294LightSources.Keys.Contains(scp294))
                    {
                        SCP294.Instance.SCP294LightSources[scp294].Destroy();
                        SCP294.Instance.SCP294LightSources.Remove(scp294);
                    }
                } catch (Exception err) { }
                scp294.Destroy();
            }
        }

        /// <summary>
        /// Set the uses the SCP-294 instance has left
        /// </summary>
        /// <param name="scp294">Instance of SCP-294 to change</param>
        /// <param name="useCount">Amount of Uses</param>
        public static void SetSCP294Uses(SchematicObject scp294, int useCount)
        {
            if (scp294 != null && SCP294.Instance.SCP294UsesLeft.Keys.Contains(scp294))
            {
                SCP294.Instance.SCP294UsesLeft[scp294] = useCount;
                // Disable and Enable
                SCP294.Instance.SCP294LightSources[scp294].Light.Range = useCount == 0 ? 0 : 1;
                SCP294.Instance.SCP294LightSources[scp294].Light.Intensity = useCount == 0 ? 0 : 0.25f;
            }
        }

        /// <summary>
        /// Plays the dispensing sound effect at the SCP-294 nearest to the player
        /// </summary>
        /// <param name="player">The Player who Triggered the Sound Effect. Used to get the SCP-294 closest to them</param>
        /// <param name="soundType">The Sound Type to play, either normal or unstable</param>
        public static void PlayDispensingSound(Player player, DrinkSound soundType) {
            SchematicObject scp294 = GetClosest294(player);

            SoundHandler.PlayAudio(new DrinkSoundFiles().List[(int)soundType], 50, false, "SCP-294", scp294.Position + new Vector3(0,1,0), 6f);
        }

        /// <summary>
        /// Check if the player is nearby a SCP-294 Instance within using distance
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static bool CanPlayerUse294(Player player) {
            foreach (SchematicObject scp294 in SCP294.Instance.SpawnedSCP294s.Keys) {
                if (!scp294) continue;
                if (Vector3.Distance(player.Position, scp294.Position) < SCP294.Instance.Config.UseDistance) return true;
            }
            return false;
        }

        /// <summary>
        /// Gets the closest SCP-294 to the player
        /// </summary>
        /// <param name="player"></param>
        /// <returns>SchematicObject reference of the SCP-294 closest to the player</returns>
        public static SchematicObject GetClosest294(Player player)
        {
            float closestDistance = 99999f;
            SchematicObject closestObject = null;
            foreach (SchematicObject scp294 in SCP294.Instance.SpawnedSCP294s.Keys)
            {
                if (!scp294) continue;
                if (Vector3.Distance(player.Position, scp294.Position) < closestDistance) {
                    closestDistance = Vector3.Distance(player.Position, scp294.Position);
                    closestObject = scp294;
                };
            }
            return closestObject;
        }

        /// <summary>
        /// A Patched version that spawns a new Drink Pickup using the created Item's Serial ID instead of giving it a new one. Important for drinks to function
        /// </summary>
        /// <param name="item"></param>
        /// <param name="position"></param>
        /// <param name="rotation"></param>
        /// <param name="spawn"></param>
        /// <returns></returns>
        public static Pickup CreateDrinkPickup(Item item, Vector3 position, Quaternion rotation = default(Quaternion), bool spawn = true)
        {
            ItemPickupBase itemPickupBase = UnityEngine.Object.Instantiate(item.Base.PickupDropModel, position, rotation);
            itemPickupBase.Info = new PickupSyncInfo(item.Type, item.Weight, item.Serial);
            itemPickupBase.gameObject.transform.localScale = item.Scale;
            Pickup pickup = Pickup.Get(itemPickupBase);
            if (spawn)
            {
                pickup.Spawn();
            }

            return pickup;
        }
    }
}

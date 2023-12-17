using Exiled.API.Enums;
using Exiled.API.Interfaces;
using SCP294.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace SCP294.Config
{
    public class Config : IConfig
    {

        // Required Config
        /// <summary>
        ///  Will the plugin run?
        /// </summary>
        [Description("Will the plugin run?")]
        public bool IsEnabled { get; set; } = true;
        /// <summary>
        ///  Will the plugin print Debug Text?
        /// </summary>
        [Description("Will the plugin print Debug Text?")]
        public bool Debug { get; set; } = false;
        /// <summary>
        /// Configure the Spawning Locations of SCP-294
        /// </summary>
        [Description("Configure the Spawning Locations of SCP-294")]
        public SpawningConfig SpawningLocations { get; set; } = new SpawningConfig() { 
            SpawnAmount = 1,
            SpawnRooms = new Dictionary<RoomType, List<SpawnTransform>>() {
                [RoomType.EzUpstairsPcs] = new List<SpawnTransform>(){
                    new SpawnTransform() {
                        Position = new Vector3(-5.15f, 0f, 2f),
                        Rotation = new Vector3(0f, -90f, 0f),
                        Scale = Vector3.one
                    } 
                },
                [RoomType.EzPcs] = new List<SpawnTransform>(){
                    new SpawnTransform() {
                        Position = new Vector3(-7f, 0f, -1.75f),
                        Rotation = new Vector3(0f, -90f, 0f),
                        Scale = Vector3.one
                    },
                    new SpawnTransform() {
                        Position = new Vector3(2.5f, 0f, 6.8f),
                        Rotation = new Vector3(0f, 0f, 0f),
                        Scale = Vector3.one
                    }
                },
                [RoomType.EzDownstairsPcs] = new List<SpawnTransform>(){
                    new SpawnTransform() {
                        Position = new Vector3(7f, -1.5f, -5.8f),
                        Rotation = new Vector3(0f, 90f, 0f),
                        Scale = Vector3.one
                    },
                    new SpawnTransform() {
                        Position = new Vector3(7f, -1.5f, 5.8f),
                        Rotation = new Vector3(0f, 90f, 0f),
                        Scale = Vector3.one
                    }
                }
            }
        };
        /// <summary>
        ///  Enable Voice Effects? Disable this if performance is subpar and you give out more than about 8 drinks per round.
        /// </summary>
        [Description("Enable Voice Effects? Disable this if performance is subpar and you give out more than about 8 drinks per round.")]
        public bool EnableVoiceEffects { get; set; } = true;
        /// <summary>
        ///  Should players be forced to get a random drink? (Player drinks will still be requestable)
        /// </summary>
        [Description("Should players be forced to get a random drink? (Player drinks will still be requestable)")]
        public bool ForceRandom { get; set; } = false;
        /// <summary>
        ///  How close to the machine does the player have to be?
        /// </summary>
        [Description("How close to the machine does the player have to be?")]
        public float UseDistance { get; set; } = 2.5f;
        /// <summary>
        /// Should the Cola be dispensed into the machine's output? Set to False to put it in the player's inventory.
        /// </summary>
        [Description("Should the Cola be dispensed into the machine's output? Set to False to put it in the player's inventory.")]
        public bool SpawnInOutput { get; set; } = true;
        /// <summary>
        /// How long should it take from command execution to dispense the drink?
        /// </summary>
        [Description("How long should it take from command execution to dispense the drink?")]
        public float DispenseDelay { get; set; } = 5.5f;
        /// <summary>
        /// Cooldown after a player uses the machine. Starts exactly as the coin is inserted
        /// </summary>
        [Description("Cooldown after a player uses the machine. Starts exactly as the coin is inserted")]
        public float CooldownTime { get; set; } = 10f;
        /// <summary>
        /// Enable to use the Community Made Drinks
        /// </summary>
        [Description("Enable to use the Community Made Drinks")]
        public bool EnableCommunityDrinks { get; set; } = true;
        /// <summary>
        /// The maximum uses of a SCP-294 machine before it deactivates. Set to -1 for infinite uses
        /// </summary>
        [Description("The maximum uses of a SCP-294 machine before it deactivates. Set to -1 for infinite uses")]
        public int MaxUsesPerMachine { get; set; } = 3;
        /// <summary>
        /// The maximum size a player can grow to from a drink.
        /// </summary>
        [Description("The maximum size a player can grow to from a drink.")]
        public Vector3 MaxSizeFromDrink { get; set; } = new Vector3(1.3f,1.3f,1.3f);
        /// <summary>
        /// The minimum size a player can shrink to from a drink.
        /// </summary>
        [Description("The minimum size a player can shrink to from a drink.")]
        public Vector3 MinSizeFromDrink { get; set; } = new Vector3(0.7f,0.7f,0.7f);
    }
}

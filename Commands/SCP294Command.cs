using CommandSystem;
using CustomPlayerEffects;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Items;
using Exiled.API.Features.Pickups;
using Exiled.API.Features.Roles;
using Exiled.Permissions.Extensions;
using MapEditorReborn.API.Features.Objects;
using MapEditorReborn.Commands.ModifyingCommands.Position;
using MapEditorReborn.Commands.ModifyingCommands.Rotation;
using MEC;
using Mirror;
using PlayerRoles;
using RemoteAdmin;
using SCP294;
using SCP294.Classes;
using SCP294.Types;
using SCP294.Types.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

namespace SCP294.Commands
{
    [CommandHandler(typeof(ClientCommandHandler))]
    public class SCP294Command : ICommand
    {
        public string Command { get; } = "scp294";

        public string[] Aliases { get; } = { "294" };

        public string Description { get; } = "Look at and stand close to SCP-294. Usage: .scp294 <drink-name> OR .scp294 player <player>";

        private System.Random rand = new System.Random();

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            // Cannot be Server
            if (!(sender is PlayerCommandSender))
            {
                response = "This command can only be ran by a player!";
                return false;
            }

            // Player MUST Be Human
            Player player = Player.Get(((PlayerCommandSender)sender).ReferenceHub);
            if (player.Role.Team == Team.Dead)
            {
                response = "Please wait until you spawn in as a normal class.";
                return false;
            }
            if (player.Role.Team == Team.SCPs)
            {
                response = "SCPs cannot interact with SCP-294.";
                return false;
            }

            // Only Continue if Player is close enough to use 294
            if (SCP294Object.CanPlayerUse294(player))
            {
                SchematicObject scp294 = SCP294Object.GetClosest294(player);
                if (SCP294.Instance.SpawnedSCP294s[scp294])
                {
                    response = "This SCP-294 is on cooldown!";
                    return false;
                }
                
                if (arguments.Count == 1 && arguments.At(0).ToLower() == "list")
                {
                    response = DrinkManager.GetAllDrinkNames();
                    return true;
                }
                
                if (SCP294.Instance.SCP294UsesLeft[scp294] == 0)
                {
                    response = "This SCP-294 has been deactivated...";
                    return false;
                }
                if (arguments.Count < 1 && !SCP294.Instance.Config.ForceRandom)
                {
                    response = "Requires you hold a coin to work | Usage: .scp294 <drink-name> OR .scp294 player <player>";
                    return false;
                }
                
                
                if (player.CurrentItem == null || player.CurrentItem.Type != ItemType.Coin)
                {
                    response = "You aren't holding a coin to buy a drink with.";
                    return false;
                }
                
                if (arguments.Count > 0 && arguments.At(0).ToLower() == "player") {
                    // Player Cup
                    // Try and Get player
                    Player targetPlayer = Player.Get(String.Join(" ", arguments.Skip(1).ToArray()));
                    if (targetPlayer != null)
                    {
                        List<DrinkEffect> stealEffects = new List<DrinkEffect>() {
                            new DrinkEffect ()
                            {
                                EffectType = EffectType.CardiacArrest,
                                Time = 8,
                                EffectAmount = 1,
                                ShouldAddIfPresent = true
                            }
                        };
                        PlayerEffectsController controller = targetPlayer.ReferenceHub.playerEffectsController;
                        foreach (DrinkEffect effect in stealEffects)
                        {
                            if (targetPlayer.TryGetEffect(effect.EffectType, out StatusEffectBase statusEffect))
                            {
                                byte newValue = (byte)Mathf.Min(255, statusEffect.Intensity + effect.EffectAmount);
                                controller.ChangeState(statusEffect.GetType().Name, newValue, effect.Time, effect.ShouldAddIfPresent);
                            }
                        }
                        targetPlayer.ShowHint($"You feel queasy, as if you're missing some of your body's contents...\n<size=20>({player.Nickname} ordered a Cup of You from SCP-294)</size>", 5);

                        // Found Drink
                        player.RemoveItem(player.CurrentItem);
                        SCP294Object.PlayDispensingSound(player, DrinkSound.Normal);
                        Timing.CallDelayed(SCP294.Instance.Config.DispenseDelay, () =>
                        {
                            Item drinkItem = Item.Create(ItemType.AntiSCP207);
                            drinkItem.Scale = new Vector3(1f, 1f, 0.8f);
                            if (SCP294.Instance.Config.SpawnInOutput)
                            {
                                Vector3 spawnPos = scp294.Position;
                                spawnPos += scp294.Rotation * new Vector3(-0.375f, 1f, -0.425f);

                                Pickup drinkPickup = SCP294Object.CreateDrinkPickup(drinkItem, spawnPos, Quaternion.Euler(-90, 0, 0));
                            }
                            else
                            {
                                player.AddItem(drinkItem);
                            }

                            SCP294.Instance.CustomDrinkItems.Add(drinkItem.Serial, new DrinkInfo()
                            {
                                ItemSerial = drinkItem.Serial,
                                ItemObject = drinkItem,
                                DrinkEffects = new List<DrinkEffect>() { },
                                DrinkMessage = "The drink tastes like blood. It's still warm.",
                                DrinkName = targetPlayer.Nickname,
                                KillPlayer = false,
                                KillPlayerString = "",
                                HealAmount = 0,
                                HealStatusEffects = false,
                                Tantrum = false
                            });
                        });

                        // Cooldown
                        SCP294.Instance.SpawnedSCP294s[scp294] = true;
                        Timing.CallDelayed(SCP294.Instance.Config.CooldownTime, () =>
                        {
                            SCP294.Instance.SpawnedSCP294s[scp294] = false;
                        });

                        SCP294Object.SetSCP294Uses(scp294, SCP294.Instance.SCP294UsesLeft[scp294] - 1);
                        response = $"SCP-294 Started Dispensing a Drink of {targetPlayer.Nickname}.";
                        return true;
                    }
                    response = "SCP-294 couldn't determine your drink, and refunded you your coin.";
                    return false;
                } 
                else if (arguments.Count > 0 && arguments.At(0).ToLower() == "playercum")
                {
                    // Player Cup
                    // Try and Get player
                    Player targetPlayer = Player.Get(String.Join(" ", arguments.Skip(1).ToArray()));
                    if (targetPlayer != null)
                    {
                        targetPlayer.ShowHint($"You feel funny, almost excited in a way...\n<size=20>({player.Nickname} ordered a Cup of You from SCP-294)</size>", 5);

                        // Found Drink
                        player.RemoveItem(player.CurrentItem);
                        SCP294Object.PlayDispensingSound(player, DrinkSound.Normal);
                        Timing.CallDelayed(SCP294.Instance.Config.DispenseDelay, () =>
                        {
                            Item drinkItem = Item.Create(ItemType.SCP207);
                            drinkItem.Scale = new Vector3(1f, 1f, 0.8f);
                            if (SCP294.Instance.Config.SpawnInOutput)
                            {
                                Vector3 spawnPos = scp294.Position;
                                spawnPos += scp294.Rotation * new Vector3(-0.375f, 1f, -0.425f);

                                Pickup drinkPickup = SCP294Object.CreateDrinkPickup(drinkItem, spawnPos, Quaternion.Euler(-90, 0, 0));
                            }
                            else
                            {
                                player.AddItem(drinkItem);
                            }

                            SCP294.Instance.CustomDrinkItems.Add(drinkItem.Serial, new DrinkInfo()
                            {
                                ItemSerial = drinkItem.Serial,
                                ItemObject = drinkItem,
                                DrinkEffects = new List<DrinkEffect>() { },
                                DrinkMessage = "Kind of salty. Tastes good though. Feels nice and warm.",
                                DrinkName = $"{targetPlayer.Nickname}'s Cum",
                                KillPlayer = false,
                                KillPlayerString = "",
                                HealAmount = 0,
                                HealStatusEffects = false,
                                Tantrum = false
                            });
                        });

                        // Cooldown
                        SCP294.Instance.SpawnedSCP294s[scp294] = true;
                        Timing.CallDelayed(SCP294.Instance.Config.CooldownTime, () =>
                        {
                            SCP294.Instance.SpawnedSCP294s[scp294] = false;
                        });

                        SCP294Object.SetSCP294Uses(scp294, SCP294.Instance.SCP294UsesLeft[scp294] - 1);
                        response = $"SCP-294 Started Dispensing a Drink of{targetPlayer.Nickname}'s Cum.";
                        return true;
                    }
                    response = "SCP-294 couldn't determine your drink, and refunded you your coin.";
                    return false;
                }
                else 
                {
                    if (SCP294.Instance.Config.ForceRandom || arguments.At(0).ToLower() == "random")
                    {
                        arguments = new ArraySegment<string>(SCP294.Instance.DrinkManager.LoadedDrinks.RandomItem<CustomDrink>().DrinkNames.RandomItem<string>().Split());
                    }

                    // Other Drinks
                    foreach (CustomDrink customDrink in SCP294.Instance.DrinkManager.LoadedDrinks)
                    {
                        foreach (string drinkName in customDrink.DrinkNames)
                        {
                            if (drinkName.ToLower() == String.Join(" ", arguments.Where(s => !String.IsNullOrEmpty(s))).ToLower()) {
                                float failNumber = (float)rand.NextDouble();
                                if (customDrink.BackfireChance > failNumber)
                                {
                                    // BACKFIRED!!!
                                    if (customDrink.ExplodeOnBackfire) {
                                        List<DrinkEffect> stealEffects = new List<DrinkEffect>() {
                                        new DrinkEffect ()
                                            {
                                                EffectType = EffectType.Ensnared,
                                                Time = SCP294.Instance.Config.DispenseDelay,
                                                EffectAmount = 1,
                                                ShouldAddIfPresent = true
                                            }
                                        };
                                        PlayerEffectsController controller = player.ReferenceHub.playerEffectsController;
                                        foreach (DrinkEffect effect in stealEffects)
                                        {
                                            if (player.TryGetEffect(effect.EffectType, out StatusEffectBase statusEffect))
                                            {
                                                byte newValue = (byte)Mathf.Min(255, statusEffect.Intensity + effect.EffectAmount);
                                                controller.ChangeState(statusEffect.GetType().Name, newValue, effect.Time, effect.ShouldAddIfPresent);
                                            }
                                        }

                                        player.RemoveItem(player.CurrentItem);
                                        SCP294Object.PlayDispensingSound(player, DrinkSound.Unstable);
                                        Timing.CallDelayed(SCP294.Instance.Config.DispenseDelay, () =>
                                        {
                                            ExplosiveGrenade grenade = (ExplosiveGrenade)Item.Create(ItemType.GrenadeHE);
                                            grenade.FuseTime = 0.1f;
                                            grenade.SpawnActive(player.Position, player);
                                            player.Kill($"Ordered a backfired {drinkName} from SCP-294");
                                        });

                                        // Cooldown
                                        SCP294.Instance.SpawnedSCP294s[scp294] = true;
                                        Timing.CallDelayed(SCP294.Instance.Config.CooldownTime, () =>
                                        {
                                            SCP294.Instance.SpawnedSCP294s[scp294] = false;
                                        });

                                        response = $"SCP-294 Started Dispensing a Drink of {drinkName}. {(SCP294.Instance.Config.ForceRandom ? "(Server Forced Random Drink)" : "")}";
                                        SCP294Object.SetSCP294Uses(scp294, SCP294.Instance.SCP294UsesLeft[scp294] - 1);
                                        return true;
                                    } else
                                    {
                                        List<DrinkEffect> stealEffects = new List<DrinkEffect>() {
                                        new DrinkEffect ()
                                            {
                                                EffectType = EffectType.CardiacArrest,
                                                Time = 8,
                                                EffectAmount = 1,
                                                ShouldAddIfPresent = true
                                            }
                                        };
                                        PlayerEffectsController controller = player.ReferenceHub.playerEffectsController;
                                        foreach (DrinkEffect effect in stealEffects)
                                        {
                                            if (player.TryGetEffect(effect.EffectType, out StatusEffectBase statusEffect))
                                            {
                                                byte newValue = (byte)Mathf.Min(255, statusEffect.Intensity + effect.EffectAmount);
                                                controller.ChangeState(statusEffect.GetType().Name, newValue, effect.Time, effect.ShouldAddIfPresent);
                                            }
                                        }
                                        player.ShowHint($"You feel queasy, as if you're missing some of your body's contents...\n<size=20>(SCP-294 Backfired, Dispensing a Cup of {player.Nickname})</size>", 5);

                                        // Found Drink
                                        player.RemoveItem(player.CurrentItem);
                                        SCP294Object.PlayDispensingSound(player, DrinkSound.Normal);
                                        Timing.CallDelayed(SCP294.Instance.Config.DispenseDelay, () =>
                                        {
                                            Item drinkItem = Item.Create(ItemType.AntiSCP207);
                                            drinkItem.Scale = new Vector3(1f, 1f, 0.8f);
                                            if (SCP294.Instance.Config.SpawnInOutput)
                                            {
                                                Vector3 spawnPos = scp294.Position;
                                                spawnPos += scp294.Rotation * new Vector3(-0.375f, 1f, -0.425f);

                                                Pickup drinkPickup = SCP294Object.CreateDrinkPickup(drinkItem, spawnPos, Quaternion.Euler(-90, 0, 0));
                                            }
                                            else
                                            {
                                                player.AddItem(drinkItem);
                                            }

                                            SCP294.Instance.CustomDrinkItems.Add(drinkItem.Serial, new DrinkInfo()
                                            {
                                                ItemSerial = drinkItem.Serial,
                                                ItemObject = drinkItem,
                                                DrinkEffects = new List<DrinkEffect>() { },
                                                DrinkMessage = "The drink tastes like blood. It's still warm.",
                                                DrinkName = player.Nickname,
                                                KillPlayer = false,
                                                KillPlayerString = "",
                                                HealAmount = 0,
                                                HealStatusEffects = false,
                                                Tantrum = false
                                            });
                                        });

                                        // Cooldown
                                        SCP294.Instance.SpawnedSCP294s[scp294] = true;
                                        Timing.CallDelayed(SCP294.Instance.Config.CooldownTime, () =>
                                        {
                                            SCP294.Instance.SpawnedSCP294s[scp294] = false;
                                        });

                                        response = $"SCP-294 Backfired!!! It Started Dispensing a Drink of {player.Nickname}";
                                        SCP294Object.SetSCP294Uses(scp294, SCP294.Instance.SCP294UsesLeft[scp294] - 1);
                                        return true;
                                    }
                                } else
                                {
                                    // Found Drink
                                    player.RemoveItem(player.CurrentItem);
                                    if (customDrink.Explode)
                                    {
                                        // BACKFIRED!!!
                                        List<DrinkEffect> stealEffects = new List<DrinkEffect>() {
                                        new DrinkEffect ()
                                            {
                                                EffectType = EffectType.Ensnared,
                                                Time = SCP294.Instance.Config.DispenseDelay,
                                                EffectAmount = 1,
                                                ShouldAddIfPresent = true
                                            }
                                        };
                                        PlayerEffectsController controller = player.ReferenceHub.playerEffectsController;
                                        foreach (DrinkEffect effect in stealEffects)
                                        {
                                            if (player.TryGetEffect(effect.EffectType, out StatusEffectBase statusEffect))
                                            {
                                                byte newValue = (byte)Mathf.Min(255, statusEffect.Intensity + effect.EffectAmount);
                                                controller.ChangeState(statusEffect.GetType().Name, newValue, effect.Time, effect.ShouldAddIfPresent);
                                            }
                                        }
                                    }
                                    SCP294Object.PlayDispensingSound(player, customDrink.Explode ? DrinkSound.Unstable : DrinkSound.Normal);
                                    Timing.CallDelayed(SCP294.Instance.Config.DispenseDelay, () =>
                                    {
                                        if (customDrink.Explode)
                                        {
                                            ExplosiveGrenade grenade = (ExplosiveGrenade)Item.Create(ItemType.GrenadeHE);
                                            grenade.FuseTime = 0.1f;
                                            grenade.SpawnActive(player.Position, player);
                                            player.Kill($"Ordered a {drinkName} from SCP-294");
                                        } else
                                        {
                                            Item drinkItem = Item.Create(customDrink.AntiColaModel ? ItemType.AntiSCP207 : ItemType.SCP207);
                                            drinkItem.Scale = new Vector3(1f, 1f, 0.8f);
                                            if (SCP294.Instance.Config.SpawnInOutput)
                                            {
                                                Vector3 spawnPos = scp294.Position;
                                                spawnPos += scp294.Rotation * new Vector3(-0.375f, 1f, -0.425f);

                                                Pickup drinkPickup = SCP294Object.CreateDrinkPickup(drinkItem, spawnPos, Quaternion.Euler(-90, 0, 0));
                                            }
                                            else
                                            {
                                                player.AddItem(drinkItem);
                                            }

                                            SCP294.Instance.CustomDrinkItems.Add(drinkItem.Serial, new DrinkInfo()
                                            {
                                                ItemSerial = drinkItem.Serial,
                                                ItemObject = drinkItem,
                                                DrinkEffects = customDrink.DrinkEffects,
                                                DrinkMessage = customDrink.DrinkMessage,
                                                DrinkName = drinkName,
                                                KillPlayer = customDrink.KillPlayer,
                                                KillPlayerString = customDrink.KillPlayerString,
                                                HealAmount = customDrink.HealAmount,
                                                HealStatusEffects = customDrink.HealStatusEffects,
                                                Tantrum = customDrink.Tantrum,
                                                DrinkCallback = customDrink.DrinkCallback
                                            });
                                        }
                                    });

                                    // Cooldown
                                    SCP294.Instance.SpawnedSCP294s[scp294] = true;
                                    Timing.CallDelayed(SCP294.Instance.Config.CooldownTime, () =>
                                    {
                                        SCP294.Instance.SpawnedSCP294s[scp294] = false;
                                    });

                                    response = $"SCP-294 Started Dispensing a Drink of {drinkName}. {(SCP294.Instance.Config.ForceRandom ? "(Server Forced Random Drink)" : "")}";
                                    SCP294Object.SetSCP294Uses(scp294, SCP294.Instance.SCP294UsesLeft[scp294] - 1);
                                    return true;
                                }
                            }
                        }
                    }
                    response = "SCP-294 couldn't determine your drink, and refunded you your coin.";
                    return false;
                }
            }

            response = "You aren't close enough to SCP-294!";
            return false;
        }
    }
}

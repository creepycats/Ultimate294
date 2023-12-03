using CommandSystem;
using CustomPlayerEffects;
using Exiled.API.Features;
using Exiled.CreditTags.Features;
using Exiled.Permissions.Extensions;
using MEC;
using RemoteAdmin;
using SCP294.Classes;
using SCP294.Types.Config;
using SCP294.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Exiled.API.Features.Items;
using Exiled.API.Enums;

namespace SCP294.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class SCP294AdminCommand : ICommand, IUsageProvider
    {
        public string Command { get; } = "scp294";

        public string[] Aliases { get; } = {  };

        public string Description { get; } = "SCP294 Admin Command Base";

        public string[] Usage { get; } = new string[1] { "create/spawn/remove/delete/setuses/givedrink" };

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (!(sender is PlayerCommandSender))
            {
                response = "This command can only be ran by a player!";
                return true;
            }

            var player = Player.Get(((PlayerCommandSender)sender).ReferenceHub);
            if (!sender.CheckPermission("SCP294.admin"))
            {
                response = "You do not have access to the Commands for SCProphunt Admin Command Base";
                return false;
            }

            if (arguments.Count < 1)
            {
                response = "Usage: scp294 create/spawn/remove/delete";
                return true;
            }

            if (arguments.At(0) == "create" || arguments.At(0) == "spawn")
            {
                SCP294Object.CreateSCP294(player.Position - new Vector3(0,1,0), Quaternion.Euler(new Vector3(0, player.Rotation.y + 180, 0)), Vector3.one);
                response = $"Created a SCP-294 at your Position and Rotation";
                return true;
            }
            else if (arguments.At(0) == "remove" || arguments.At(0) == "delete")
            {
                SCP294Object.RemoveSCP294(SCP294Object.GetClosest294(player));
                response = $"Removed the nearest SCP-294 instance";
                return true;
            }
            else if (arguments.At(0) == "setuses")
            {
                int useAmount = 0;
                if (int.TryParse(arguments.At(1), out useAmount))
                {
                    SCP294Object.SetSCP294Uses(SCP294Object.GetClosest294(player),useAmount);
                    response = $"Set the nearest SCP-294 instance's uses to {useAmount}";
                    return true;
                } else
                {
                    response = $"Parameter is not of type Int";
                    return false;
                }
            }
            else if (arguments.At(0) == "givedrink")
            {
                if (arguments.At(1).ToLower() == "player")
                {
                    // Player Cup
                    // Try and Get player
                    Player targetPlayer = Player.Get(String.Join(" ", arguments.Skip(2).ToArray()));
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
                        Item drinkItem = Item.Create(ItemType.SCP207);
                        drinkItem.Scale = new Vector3(1f, 1f, 0.8f);
                        player.AddItem(drinkItem);

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

                        response = $"Gave yourself a Drink of {targetPlayer.Nickname}.";
                        return true;
                    }
                    response = "Couldn't Find a Drink with this Name";
                    return false;
                }
                else if (arguments.At(1).ToLower() == "playercum")
                {
                    // Player Cup
                    // Try and Get player
                    Player targetPlayer = Player.Get(String.Join(" ", arguments.Skip(2).ToArray()));
                    if (targetPlayer != null)
                    {
                        targetPlayer.ShowHint($"You feel funny, almost excited in a way...\n<size=20>({player.Nickname} ordered a Cup of You from SCP-294)</size>", 5);

                        // Found Drink
                        Item drinkItem = Item.Create(ItemType.SCP207);
                        drinkItem.Scale = new Vector3(1f, 1f, 0.8f);
                        player.AddItem(drinkItem);

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

                        response = $"Gave yourself a Drink of {targetPlayer.Nickname}'s Cum.";
                        return true;
                    }
                    response = "Couldn't Find a Drink with this Name";
                    return false;
                }
                else
                {
                    // Other Drinks
                    foreach (CustomDrink customDrink in SCP294.Instance.DrinkManager.LoadedDrinks)
                    {
                        foreach (string drinkName in customDrink.DrinkNames)
                        {
                            if (drinkName.ToLower() == String.Join(" ", arguments.Skip(1).Where(s => !String.IsNullOrEmpty(s))).ToLower())
                            {
                                // Found Drink
                                Item drinkItem = Item.Create(ItemType.SCP207);
                                drinkItem.Scale = new Vector3(1f, 1f, 0.8f);
                                player.AddItem(drinkItem);
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

                                response = $"Gave yourself a Drink of {drinkName}.";
                                return true;
                            }
                        }
                    }
                    response = "Couldn't Find a Drink with this Name";
                    return false;
                }
            }
            else
            {
                response = "Invalid Subcommand.";
                return false;
            }

            response = "Something is very wrong. Let me know if you somehow get this result.";
            return false;
        }
    }
}

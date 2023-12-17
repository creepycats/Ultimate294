using CustomPlayerEffects;
using Exiled.API.Enums;
using Exiled.Events.EventArgs.Player;
using Hazards;
using MEC;
using Mirror;
using PlayerRoles;
using PlayerRoles.PlayableScps.Scp173;
using RelativePositioning;
using SCP294.Types;
using SCP294.Types.Config;
using System;
using UnityEngine;

namespace SCP294.handlers
{
    public class playerHandler
    {
        public void Joined(JoinedEventArgs args)
        {

        }

        public void ChangingItem(ChangingItemEventArgs args) {
            if (args.Player == null) return;
            if (args.Item == null) return;
            if (args.Player.IsNPC) return;

            if (SCP294.Instance.CustomDrinkItems.TryGetValue(args.Item.Serial, out DrinkInfo drinkInfo))
            {
                args.Player.ShowHint($"You pulled out the Drink of {drinkInfo.DrinkName}", 3);
            }
        }

        public void UsedItem(UsedItemEventArgs args)
        {
            if (args.Player == null) return;
            if (args.Item == null) return;
            if (args.Player.IsNPC) return;

            if (SCP294.Instance.CustomDrinkItems.TryGetValue(args.Item.Serial, out DrinkInfo drinkInfo))
            {
                if (args.Player.IsScp)
                {
                    Timing.CallDelayed(0.01f, () =>
                    {
                        PlayerEffectsController controller = args.Player.ReferenceHub.playerEffectsController;
                        if (args.Player.TryGetEffect(args.Item.Type == ItemType.AntiSCP207 ? EffectType.AntiScp207 : EffectType.Scp207, out StatusEffectBase statusEffect))
                        {
                            byte newValue = (byte)Mathf.Min(255, statusEffect.Intensity - 1);
                            controller.ChangeState(statusEffect.GetType().Name, newValue, 0, false);
                        }
                    });
                }

                // Run any Callbacks
                if (drinkInfo.DrinkCallback != null) drinkInfo.DrinkCallback(args.Player);

                // Show the Message for Drinking
                args.Player.ShowHint(drinkInfo.DrinkMessage, 5);

                args.Player.CurrentItem = null;

                if (drinkInfo.KillPlayer)
                {
                    DrinkCallbacks.DrinkKill(args.Player, drinkInfo);
                } else
                {
                    args.Player.Heal(drinkInfo.HealAmount);
                    // Give player effects from drink
                    PlayerEffectsController controller = args.Player.ReferenceHub.playerEffectsController;
                    if (drinkInfo.HealStatusEffects)
                    {
                        foreach (EffectType effect in Enum.GetValues(typeof(EffectType)))
                        {
                            if (args.Player.TryGetEffect(effect, out StatusEffectBase statusEffect))
                            {
                                byte newValue = (byte)Mathf.Min(255, 0);
                                controller.ChangeState(statusEffect.GetType().Name, newValue, 0, false);
                            }
                        }
                    }
                    foreach (DrinkEffect effect in drinkInfo.DrinkEffects)
                    {
                        if (args.Player.TryGetEffect(effect.EffectType, out StatusEffectBase statusEffect))
                        {
                            byte newValue = (byte)Mathf.Min(255, statusEffect.Intensity + effect.EffectAmount);
                            controller.ChangeState(statusEffect.GetType().Name, newValue, effect.Time, effect.ShouldAddIfPresent);
                        }
                    }
                }
                 
                // Spawn Tantrum when player Drink Funny
                if (drinkInfo.Tantrum)
                {
                    if (PlayerRoleLoader.TryGetRoleTemplate(RoleTypeId.Scp173, out PlayerRoleBase result))
                    {
                        Scp173TantrumAbility ability = ((Scp173Role)result).GetComponentInChildren<Scp173TantrumAbility>();

                        if (Physics.Raycast(args.Player.Position, Vector3.down, out RaycastHit hitInfo, 3f, ability._tantrumMask))
                        {
                            TantrumEnvironmentalHazard tantrumEnvironmentalHazard = UnityEngine.Object.Instantiate(ability._tantrumPrefab);
                            Vector3 targetPos = hitInfo.point + (Vector3.up * 1.25f);
                            tantrumEnvironmentalHazard.SynchronizedPosition = new RelativePosition(targetPos);
                            NetworkServer.Spawn(tantrumEnvironmentalHazard.gameObject);
                            foreach (TeslaGate teslaGate in TeslaGateController.Singleton.TeslaGates)
                            {
                                if (teslaGate.IsInIdleRange(args.Player.Position))
                                {
                                    teslaGate.TantrumsToBeDestroyed.Add(tantrumEnvironmentalHazard);
                                }
                            }
                        }
                    }
                }

                SCP294.Instance.CustomDrinkItems.Remove(args.Item.Serial);
            }
        }
    }
}

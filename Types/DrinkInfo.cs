using Exiled.API.Features;
using Exiled.API.Features.Items;
using InventorySystem.Items;
using SCP294.Types.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SCP294.Types
{
    public class DrinkInfo
    {
        /// <summary>
        /// The Item Serial ID this Info is Attached To
        /// </summary>
        public ushort ItemSerial { get; set; } = 0;
        /// <summary>
        /// The Reference to the Item Object
        /// </summary>
        public Item ItemObject { get; set; } = null;
        /// <summary>
        /// The Drink's Name which was put into 294
        /// </summary>
        public string DrinkName { get; set; } = "";
        /// <summary>
        /// The message to display when the player drinks the drink
        /// </summary>
        public string DrinkMessage { get; set; } = "";
        /// <summary>
        /// Kill the player when ingested?
        /// </summary>
        public bool KillPlayer { get; set; } = false;
        /// <summary>
        /// Death Reason for Kill on ingestion
        /// </summary>
        public string KillPlayerString { get; set; } = "";
        /// <summary>
        /// How much HP the player drinking gets healed
        /// </summary>
        public float HealAmount { get; set; } = 0;
        /// <summary>
        /// Should the Drink act like SCP-500
        /// </summary>
        public bool HealStatusEffects { get; set; } = false;
        /// <summary>
        /// Should using the Drink force a tantrum puddle?
        /// </summary>
        public bool Tantrum { get; set; } = false;
        /// <summary>
        /// List of effects to apply when Drinking the Custom Drink
        /// </summary>
        public List<DrinkEffect> DrinkEffects { get; set; } = new List<DrinkEffect>()
        {

        };
        public Action<Player> DrinkCallback = null;

        /// <summary>
        /// Check if a Drink is a Custom Drink from SCP-294
        /// </summary>
        /// <param name="Base"></param>
        /// <returns></returns>
        public static bool IsCustomDrink(ItemBase itembase) {
            return SCP294.Instance.CustomDrinkItems.Keys.Contains(itembase.ItemSerial);
        }
    }
}
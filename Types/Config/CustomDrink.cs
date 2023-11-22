using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCP294.Types.Config
{
    public class CustomDrink
    {
        /// <summary>
        /// Accepted list of Drink Names
        /// </summary>
        public List<string> DrinkNames { get; set; } = new List<string>(){
            ""
        };
        /// <summary>
        /// Should the Drink use the AntiCola model instead of the normal Cola Model
        /// </summary>
        public bool AntiColaModel { get; set; } = false;
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
        /// Should the Drink Explode when Purchased
        /// </summary>
        public bool Explode { get; set; } = false;
        /// <summary>
        /// Should the Drink Explode when Backfired
        /// </summary>
        public bool ExplodeOnBackfire { get; set; } = false;
        /// <summary>
        /// Float representing the chance out of 1.0f that the drink will instead yield the player a cup of themselves
        /// </summary>
        public float BackfireChance { get; set; } = 0f;
        /// <summary>
        /// The Message that will appear when you Drink the Custom Drink
        /// </summary>
        public string DrinkMessage { get; set; } = "You drank the placeholder drink. Very cool";
        /// <summary>
        /// List of effects to apply when Drinking the Custom Drink
        /// </summary>
        public List<DrinkEffect> DrinkEffects { get; set; } = new List<DrinkEffect>()
        {

        };
        public Action<Player> DrinkCallback { get; set; } = null;
    }
}

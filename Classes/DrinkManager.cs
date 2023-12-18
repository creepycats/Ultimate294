using SCP294.Types.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEC;
using MapEditorReborn.API.Features.Objects;
using Exiled.API.Features;
using HarmonyLib;

namespace SCP294.Classes
{
    public class DrinkManager
    {
        public List<CustomDrink> LoadedDrinks = new List<CustomDrink>() { };

        public void UnloadAllDrinks()
        {
            LoadedDrinks = new List<CustomDrink>() { };
        }

        public void LoadBaseDrinks()
        {
            LoadedDrinks = LoadedDrinks.Concat(DrinkList.DefaultDrinks).ToList();
            if (SCP294.Instance.Config.EnableCommunityDrinks) LoadedDrinks = LoadedDrinks.Concat(DrinkList.CommunityDrinks).ToList();
        }

        public void UnloadBaseDrinks()
        {
            LoadedDrinks = LoadedDrinks.Except(DrinkList.DefaultDrinks).ToList();
            if (SCP294.Instance.Config.EnableCommunityDrinks) LoadedDrinks = LoadedDrinks.Except(DrinkList.CommunityDrinks).ToList();
        }

        public static bool IsDrinkManagerLoaded() { return SCP294.Instance.DrinkManager.LoadedDrinks != null; }

        public static void RegisterDrink(CustomDrink newDrink)
        {
            RegisterDrink(new CustomDrink[] { newDrink });
        }
        public static void RegisterDrink(CustomDrink[] newDrink) 
        {
            Timing.RunCoroutine(AwaitAddDrink(newDrink));
        }

        public static IEnumerator<float> AwaitAddDrink(CustomDrink[] newDrink)
        {
            yield return Timing.WaitUntilTrue(IsDrinkManagerLoaded);
            SCP294.Instance.DrinkManager.LoadedDrinks = SCP294.Instance.DrinkManager.LoadedDrinks.Concat(newDrink.ToList()).ToList();
        }

        public static void UnloadDrink(CustomDrink newDrink)
        {
            UnloadDrink(new CustomDrink[] { newDrink });
        }
        public static void UnloadDrink(CustomDrink[] newDrink)
        {
            Timing.RunCoroutine(AwaitRemoveDrink(newDrink));
        }

        public static IEnumerator<float> AwaitRemoveDrink(CustomDrink[] newDrink)
        {
            while (SCP294.Instance.DrinkManager == null)
            {
                yield return Timing.WaitForSeconds(1f);
            }

            SCP294.Instance.DrinkManager.LoadedDrinks = SCP294.Instance.DrinkManager.LoadedDrinks.Except(newDrink.ToList()).ToList();
        }

        /*
         * Gets all Drink names for .scp294 list command
         */
        
        public static string GetAllDrinkNames()
        {
            List<string> allDrinkNamesList = new List<string>();
            String allDrinkNames = " ";
            
            foreach (CustomDrink customDrink in SCP294.Instance.DrinkManager.LoadedDrinks)
            {
                foreach (string drinkName in customDrink.DrinkNames)
                {
                    allDrinkNamesList.Add(drinkName);
                }
            }
            allDrinkNames = String.Join(", ", allDrinkNamesList);
            return allDrinkNames;
        }
    }
}

using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;
using Server = Exiled.Events.Handlers.Server;
using System;
using System.Collections.Generic;
using MEC;
using MapEditorReborn.API.Features.Objects;
using SCP294.Classes;
using SCP294.Types;
using HarmonyLib;
using Exiled.API.Enums;

namespace SCP294
{
    public class SCP294 : Plugin<Config.Config>
    {
        public override string Name => "Ultimate294";
        public override string Author => "creepycats";
        public override Version Version => new Version(1, 1, 0);

        public override PluginPriority Priority => PluginPriority.Highest;

        public static SCP294 Instance { get; set; }

        public Dictionary<SchematicObject, bool> SpawnedSCP294s { get; set; } = new Dictionary<SchematicObject, bool>();
        public Dictionary<SchematicObject, int> SCP294UsesLeft { get; set; } = new Dictionary<SchematicObject, int>();
        public Dictionary<SchematicObject, LightSourceObject> SCP294LightSources { get; set; } = new Dictionary<SchematicObject, LightSourceObject>();
        public List<string> PlayersNear294 { get; set; } = new List<string>();
        public Dictionary<ushort, DrinkInfo> CustomDrinkItems = new Dictionary<ushort, DrinkInfo>();
        public DrinkManager DrinkManager = new DrinkManager();

        private Harmony _harmony;

        private CoroutineHandle hintCoroutine;

        public override void OnEnabled()
        {
            Instance = this;
            Log.Info($"{Name} v{Version} - made by creepycats");
            if (Config.Debug)
                Log.Info("Registering events...");
            RegisterEvents();

            DrinkManager.LoadBaseDrinks();

            hintCoroutine = Timing.RunCoroutine(SCP294Object.Handle294Hint());

            _harmony = new Harmony("SCP294");
            _harmony.PatchAll();

            Log.Info("Plugin Enabled!");
        }
        public override void OnDisabled()
        {
            if (Config.Debug)
                Log.Info("Unregistering events...");
            UnregisterEvents();

            DrinkManager.UnloadAllDrinks();

            Timing.KillCoroutines(hintCoroutine);

            _harmony.UnpatchAll();
            _harmony = null;

            Log.Info("Disabled Plugin Successfully");
        }

        // NotesToSelf
        // OBJECT.EVENT += FUNCTION > Add Function to Callback
        // OBJECT.EVENT -= FUNCTION > Remove Function from Callback

        private handlers.serverHandler ServerHandler;
        private handlers.playerHandler PlayerHandler;

        public void RegisterEvents() 
        {
            ServerHandler = new handlers.serverHandler();
            PlayerHandler = new handlers.playerHandler();

            Server.RoundStarted += ServerHandler.WaitingForPlayers;

            Player.ChangingItem += PlayerHandler.ChangingItem;
            Player.UsedItem += PlayerHandler.UsedItem;
        }
        public void UnregisterEvents()
        {
            Server.RoundStarted -= ServerHandler.WaitingForPlayers;

            Player.ChangingItem -= PlayerHandler.ChangingItem;
            Player.UsedItem -= PlayerHandler.UsedItem;
        }
    }
}
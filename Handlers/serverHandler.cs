using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events;
using Exiled.Events.EventArgs;
using SCP294.Utils;
using System.Collections.Generic;
using MapEditorReborn.API;
using MapEditorReborn.API.Features;
using MapEditorReborn.Commands.ModifyingCommands.Scale;
using UnityEngine;
using SCP294.Classes;
using MapEditorReborn.API.Features.Objects;
using SCP294.Types;

namespace SCP294.handlers
{
    public class serverHandler
    {
        public void WaitingForPlayers() {
            SCP294.Instance.SpawnedSCP294s = new Dictionary<SchematicObject, bool>();
            SCP294.Instance.PlayersNear294 = new List<string>();
            SCP294.Instance.CustomDrinkItems = new Dictionary<ushort, DrinkInfo>();
            SCP294Object.SpawnSCP294();
        }
    }
}

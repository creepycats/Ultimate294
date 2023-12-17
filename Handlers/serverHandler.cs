using MapEditorReborn.API.Features.Objects;
using SCP294.Classes;
using SCP294.Types;
using System.Collections.Generic;
using VoiceChat.Codec;

namespace SCP294.handlers
{
    public class serverHandler
    {
        public void WaitingForPlayers() {
            SCP294.Instance.SpawnedSCP294s = new Dictionary<SchematicObject, bool>();
            SCP294.Instance.PlayersNear294 = new List<string>();
            SCP294.Instance.CustomDrinkItems = new Dictionary<ushort, DrinkInfo>();
            SCP294.Instance.PlayerVoicePitch = new Dictionary<string, float>();
            SCP294.Instance.Encoders = new Dictionary<ReferenceHub, OpusComponent>();
            SCP294Object.SpawnSCP294();
        }
    }
}

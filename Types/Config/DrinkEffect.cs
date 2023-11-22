using Exiled.API.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCP294.Types.Config
{
    public sealed class DrinkEffect
    {
        public EffectType EffectType { get; set; }

        public bool ShouldAddIfPresent { get; set; }

        public float Time { get; set; }

        public byte EffectAmount { get; set; }
    }
}

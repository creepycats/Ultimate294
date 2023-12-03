using Exiled.API.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SCP294.Types
{
    public class SpawnTransform
    {
        /// <summary>
        /// The position for SCP-294 to spawn at, relative to room's transform
        /// </summary>
        public Vector3 Position { get; set; } = new Vector3(0, 0, 0);
        /// <summary>
        /// The rotation for SCP-294 to spawn at, relative to room's transform
        /// </summary>
        public Vector3 Rotation { get; set; } = new Vector3(0, 0, 0);
        /// <summary>
        /// The scale for SCP-294's schematic, default Vector3.one
        /// </summary>
        public Vector3 Scale { get; set; } = Vector3.one;
    }
}

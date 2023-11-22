using Exiled.API.Enums;
using Exiled.API.Interfaces;
using SCP294.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace SCP294.Config
{
    public class Config : IConfig
    {

        // Required Config
        /// <summary>
        ///  Will the plugin run?
        /// </summary>
        public bool IsEnabled { get; set; } = true;
        /// <summary>
        ///  Will the plugin print Debug Text?
        /// </summary>
        public bool Debug { get; set; } = false;
        /// <summary>
        /// Configure the Spawning Locations of SCP-294
        /// </summary>
        public SpawningConfig SpawningLocations { get; set; } = new SpawningConfig() { 
            SpawnAmount = 1,
            SpawnRooms = new Dictionary<RoomType, List<SpawnTransform>>() {
                [RoomType.EzUpstairsPcs] = new List<SpawnTransform>(){
                    new SpawnTransform() {
                        Position = new Vector3(-5.15f, 0f, 2f),
                        Rotation = new EulerRotation() {
                            X = 0,
                            Y = -90,
                            Z = 0
                        },
                        Scale = Vector3.one
                    } 
                },
                [RoomType.EzPcs] = new List<SpawnTransform>(){
                    new SpawnTransform() {
                        Position = new Vector3(-7f, 0f, -1.75f),
                        Rotation = new EulerRotation() {
                            X = 0,
                            Y = -90,
                            Z = 0
                        },
                        Scale = Vector3.one
                    },
                    new SpawnTransform() {
                        Position = new Vector3(2.5f, 0f, 6.8f),
                        Rotation = new EulerRotation() {
                            X = 0,
                            Y = 0,
                            Z = 0
                        },
                        Scale = Vector3.one
                    }
                },
                [RoomType.EzDownstairsPcs] = new List<SpawnTransform>(){
                    new SpawnTransform() {
                        Position = new Vector3(7f, -1.5f, -5.8f),
                        Rotation = new EulerRotation() {
                            X = 0,
                            Y = 90,
                            Z = 0
                        },
                        Scale = Vector3.one
                    },
                    new SpawnTransform() {
                        Position = new Vector3(7f, -1.5f, 5.8f),
                        Rotation = new EulerRotation() {
                            X = 0,
                            Y = 90,
                            Z = 0
                        },
                        Scale = Vector3.one
                    }
                }
            }
        };
        /// <summary>
        ///  Will the plugin print Debug Text?
        /// </summary>
        public float UseDistance { get; set; } = 2.5f;
        /// <summary>
        /// Should the Cola be dispensed into the machine's output? Set to False to put it in the player's inventory.
        /// </summary>
        public bool SpawnInOutput { get; set; } = true;
        /// <summary>
        /// How long should it take from command execution to dispense the drink?
        /// </summary>
        public float DispenseDelay { get; set; } = 5.5f;
        /// <summary>
        /// Cooldown after a player uses the machine. Starts exactly as the coin is inserted
        /// </summary>
        public float CooldownTime { get; set; } = 10f;
        /// <summary>
        /// Enable to use the Community Made Drinks
        /// </summary>
        public bool EnableCommunityDrinks { get; set; } = true;
        /// <summary>
        /// The maximum uses of a SCP-294 machine before it deactivates. Set to -1 for infinite uses
        /// </summary>
        public int MaxUsesPerMachine { get; set; } = 3;
        /// <summary>
        /// The maximum size a player can grow to from a drink.
        /// </summary>
        public Vector3 MaxSizeFromDrink { get; set; } = new Vector3(1.3f,1.3f,1.3f);
        /// <summary>
        /// The minimum size a player can grow to from a drink.
        /// </summary>
        public Vector3 MinSizeFromDrink { get; set; } = new Vector3(0.7f,0.7f,0.7f);
    }
}

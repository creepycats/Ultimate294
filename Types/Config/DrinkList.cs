using Exiled.API.Enums;
using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace SCP294.Types.Config
{
    public class DrinkList
    {
        public static List<CustomDrink> DefaultDrinks = new List<CustomDrink>() {
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Water",
                    "H2O",
                    "Mineral Water",
                    "Soda Water",
                    "Seltzer"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "Well, that was refreshing.",
                DrinkEffects = new List<DrinkEffect>(){ }
            }, // Water
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "cola",
                    "coke",
                    "207",
                    "scp207",
                    "scp-207",
                    "soda"
                },
                AntiColaModel = false,
                HealAmount = 30f,
                BackfireChance = 0.4f,
                DrinkMessage = "It's cold and refreshing.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Scp207,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    }
                }
            }, // SCP-207
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "acola",
                    "acoke",
                    "a207",
                    "ascp207",
                    "ascp-207",
                    "asoda",
                    "a-cola",
                    "a-coke",
                    "a-207",
                    "a-scp207",
                    "a-scp-207",
                    "a-soda",
                    "anticola",
                    "anticoke",
                    "anti207",
                    "antiscp207",
                    "antiscp-207",
                    "antisoda",
                    "anti-cola",
                    "anti-coke",
                    "anti-207",
                    "anti-scp207",
                    "anti-scp-207",
                    "anti-soda"
                },
                AntiColaModel = true,
                BackfireChance = 0.4f,
                DrinkMessage = "It's cold and refreshing..?",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect()
                    {
                        EffectType = EffectType.AntiScp207,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    }
                }
            }, // Anti SCP-207
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Air",
                    "Nothing",
                    "Cup",
                    "Emptiness",
                    "Vacuum",
                    "HL3",
                    "Half Life 3"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "The Liquid vanishes as it enters your mouth,\nleaving you with nothing but a Cup",
                DrinkEffects = new List<DrinkEffect>(){ }
            }, // Air
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Alcohol",
                    "Ethanol",
                    "Ethanol Liquid",
                    "Spirit",
                    "Vodka"
                },
                AntiColaModel = true,
                BackfireChance = 0.00f,
                DrinkMessage = "Damn, that's strong.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 5,
                        ShouldAddIfPresent = true
                    }
                }
            }, // Alcohol
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Amnesia"
                },
                AntiColaModel = true,
                BackfireChance = 0.00f,
                DrinkMessage = "Daniel, is that you? What are you doing?",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 10,
                        ShouldAddIfPresent = true
                    },
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.AmnesiaItems,
                        Time = 10,
                        ShouldAddIfPresent = true
                    },
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.AmnesiaVision,
                        Time = 10,
                        ShouldAddIfPresent = true
                    }
                }
            }, // Amnesia
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Anti-Energy Drink",
                    "Anti Energy Drink"
                },
                AntiColaModel = true,
                BackfireChance = 0.00f,
                DrinkMessage = "The drink tastes terrible. You feel tired and drained.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Disabled,
                        Time = 300,
                        ShouldAddIfPresent = true
                    }
                }
            }, // Anti Energy Drink
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Anti-matter",
                    "Antimatter",
                    "Void",
                    "Atomic",
                    "Nuke",
                    "Nuclear",
                    "Nuclear Fusion",
                    "Nuclear Fission",
                    "Nuclear Reaction",
                    "Exotic Matter",
                    "Zero Point Energy",
                    "Negative Matter",
                    "Gravitons",
                    "Higgs Boson",
                    "God Particles",
                    "Black Holes",
                    "Quarks",
                    "Glouns",
                    "Quark Gloun Plasma",
                    "Tachyons",
                    "Tachyonic Matter",
                    "Imaginary Matter",
                    "Neutrinos",
                    "God",
                    "Christ",
                    "Jesus",
                    "Jesus Christ",
                    "SCP-343",
                    "SCP 343",
                    "SCP343",
                    "343"
                },
                AntiColaModel = false,
                Explode = true,
                BackfireChance = 0.00f,
                DrinkMessage = "BOOM BOOM!!!",
                DrinkEffects = new List<DrinkEffect>(){}
            }, // Explody Bois
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Aqua Regia"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "You spit it out immediately.\nHmm. . . There should be more cuprite.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Aqua Regia
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Beer",
                    "Lager"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "The drink tastes like a standard pale lager.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Beer
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Black Corrosive Liquid",
                    "SCP-106",
                    "106",
                    "Old Man"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "You feel strange. It's as if there was something moving in your stomach",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 8,
                        ShouldAddIfPresent = true
                    },
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Bleeding,
                        Time = 120,
                        ShouldAddIfPresent = true
                    },
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Traumatized,
                        Time = 0,
                        ShouldAddIfPresent = true
                    }
                }
            }, // Corrosive Liquid / 106
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Bleach"
                },
                AntiColaModel = true,
                BackfireChance = 0.00f,
                DrinkMessage = "The liquid burns in your mouth and throat.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Bleeding,
                        Time = 300,
                        ShouldAddIfPresent = true
                    },
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.CardiacArrest,
                        Time = 300,
                        ShouldAddIfPresent = true
                    }
                }
            }, // Bleach
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Blood"
                },
                AntiColaModel = true,
                BackfireChance = 0.00f,
                DrinkMessage = "The drink tastes like red wine.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Bleeding,
                        Time = 30,
                        ShouldAddIfPresent = true
                    }
                }
            }, // Blood
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Blood of Christ",
                    "Blood of Jesus",
                    "Blood of Jesus Christ"
                },
                AntiColaModel = true,
                BackfireChance = 0.00f,
                DrinkMessage = "The drink tastes like red wine.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Blood of Christ
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Bose-Einstein Condensate",
                    "Quantum Gas"
                },
                AntiColaModel = true,
                KillPlayer = true,
                KillPlayerString = "Drank something they shouldn't have from SCP-294",
                BackfireChance = 0.00f,
                DrinkMessage = "",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Quantum Gas
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Butt Ghost",
                    "Liquid Butt Ghost"
                },
                AntiColaModel = false,
                KillPlayer = true,
                KillPlayerString = "Had their Ass eaten after ingesting Liquid Butt Ghost",
                BackfireChance = 0.00f,
                DrinkMessage = "Ouch my ass is being eaten.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Butt Ghost
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Carbon"
                },
                AntiColaModel = false,
                KillPlayer = true,
                KillPlayerString = "Drank something they shouldn't have from SCP-294",
                BackfireChance = 0.00f,
                DrinkMessage = "",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Carbon
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Cassis Fanta"
                },
                AntiColaModel = true,
                BackfireChance = 0.00f,
                DrinkMessage = "Refreshing...",
                DrinkEffects = new List<DrinkEffect>(){
                }
            }, // Cassis Fanta
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Carrot Juice",
                    "Carrot"
                },
                AntiColaModel = true,
                BackfireChance = 0.00f,
                DrinkMessage = "Pretty good.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Carrot
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Champagne"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "Not Bad.",
                DrinkEffects = new List<DrinkEffect>(){
                }
            }, // Champagne
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Chim"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "There are no words in any human language to describe the taste of this liquid.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 100,
                        ShouldAddIfPresent = true
                    },
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Vitality,
                        Time = 100,
                        ShouldAddIfPresent = true
                    }
                }
            }, // Chim
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Cider",
                    "Apple Cider",
                    "Pear Cider"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "A bit too sugary for me.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Cider
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Chocolate",
                    "Cocoa",
                    "Hot Chocolate",
                    "Hot Cocoa"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "Mmmm...",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 2,
                        ShouldAddIfPresent = true
                    }
                }
            }, // Chocolate
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Cocaine",
                    "Cocaine Energy Drink"
                },
                AntiColaModel = true,
                BackfireChance = 0.00f,
                DrinkMessage = "The drink has a boost, and taste faintly hot with a hint of cinnamon.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 5,
                        ShouldAddIfPresent = true
                    },
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Scp207,
                        Time = 200,
                        ShouldAddIfPresent = true
                    }
                }
            }, // Cocaine Energy Drink
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Coffee",
                    "Black Coffee"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "The drink tastes like fairly strong black coffee.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 2,
                        ShouldAddIfPresent = true
                    }
                }
            }, // Coffee
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Coconut",
                    "Coconut Milk",
                    "Coconut Water",
                    "Coconut Juice"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "You enjoy the refreshing flavor of coconut milk.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Coconut
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Cold",
                    "Cool",
                    "Freezing",
                    "Coldness"
                },
                AntiColaModel = true,
                BackfireChance = 0.00f,
                DrinkMessage = "Your head aches from the freezing cold liquid.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 8,
                        ShouldAddIfPresent = true
                    }
                }
            }, // Cold
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Cosmopolitan",
                    "Cocktail",
                    "Cosmopolitan Cocktail",
                },
                AntiColaModel = true,
                BackfireChance = 0.00f,
                DrinkMessage = "Even in the worst situations, nothing beats a fresh cosmopolitan.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Cosmopolitan Cocktail
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Courage",
                    "Bravery"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "Suddenly, you feel like you can do anything...",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Invigorated,
                        Time = 180,
                        ShouldAddIfPresent = true
                    }
                }
            }, // Courage
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Curry",
                    "Masala",
                    "Curry Sauce",
                    "Masala Sauce"
                },
                AntiColaModel = true,
                BackfireChance = 0.00f,
                DrinkMessage = "Full of exotic spices and flavors, wet consistency, delicious.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Curry
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Death",
                    "Game Over"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "Expected.",
                KillPlayer = true,
                KillPlayerString = "You drank Death. This was expected",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Death
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Egg",
                    "Eggs"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "It tastes just like raw eggs!",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Eggs
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Element 0",
                    "Element Zero",
                    "Neutronium",
                    "Neutrium",
                    "Tetraneutron"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "You didn't think Biotic Powers were real? Right?",
                KillPlayer = true,
                KillPlayerString = "You didn't think Biotic Powers were real? Right?",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Element 0
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "ES",
                    "Euroshopper",
                    "Euroshopper Energy Drink",
                    "Energy Drink",
                    "Red Bull"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "The drink tastes like an average energy drink.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Invigorated,
                        Time = 180,
                        ShouldAddIfPresent = true
                    }
                }
            }, // Energy Drink/ES
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Espresso"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "Pretty nice...",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Espresso
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Estus"
                },
                HealAmount = 100,
                HealStatusEffects = true,
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "The taste is hard to describe. You feel refreshed.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Estus
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Eternal Champion",
                    "Blood of Eternal Champion",
                    "Talin Warhaft"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                HealAmount = 50,
                DrinkMessage = "I graciously accept thy position, my Emperor.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Invigorated,
                        Time = 30,
                        ShouldAddIfPresent = true
                    },
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 10,
                        ShouldAddIfPresent = true
                    }
                }
            }, // Eternal Champion
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Fear",
                    "Scare",
                    "Horror",
                    "Terror"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "T H E   F O G   I S   C O M I N G",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 50,
                        ShouldAddIfPresent = true
                    },
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.SinkHole,
                        Time = 50,
                        ShouldAddIfPresent = true
                    },
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Traumatized,
                        Time = 50,
                        ShouldAddIfPresent = true
                    },
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.SeveredHands,
                        Time = 0,
                        ShouldAddIfPresent = true
                    }
                }
            }, // Fear
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Feces",
                    "Fecal Matter",
                    "Shit",
                    "Crap",
                    "Poo",
                    "Poop",
                    "Dung",
                    "Scat",
                    "Turd",
                    "Bullshit",
                    "Horseshit",
                    "Diarrhea"
                },
                Tantrum = true,
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "Yeah, I'm throwing that out.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Feces / SHIT
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Feces and Blood",
                    "Blood and Feces"
                },
                Tantrum = true,
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "The drink smells like SCP-173's containment chamber.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Feces and Blood / 173
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Gin",
                    "Gin and Tonic",
                    "Gin & Tonic"
                },
                AntiColaModel = true,
                BackfireChance = 0.00f,
                DrinkMessage = "Gin has never tasted this good.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Gin Tonic
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Glass",
                    "Gold"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "I should not have drunken that...",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 5,
                        ShouldAddIfPresent = true
                    },
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Bleeding,
                        Time = 180,
                        ShouldAddIfPresent = true
                    },
                }
            }, // Glass, Gold
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Grog"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "It's been too long since you've had a good drink.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 5,
                        ShouldAddIfPresent = true
                    }
                }
            }, // Coffee
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Happiness",
                    "Cheerfulness",
                    "Joy"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "An overwhelming sense of happiness takes you over. Your heart is pounding like crazy.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.CardiacArrest,
                        Time = 30,
                        ShouldAddIfPresent = true
                    },
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 30,
                        ShouldAddIfPresent = true
                    }
                }
            }, // Happiness
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Heroin",
                    "Morphine"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "The liquid tastes awful.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.CardiacArrest,
                        Time = 30,
                        ShouldAddIfPresent = true
                    },
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 30,
                        ShouldAddIfPresent = true
                    }
                }
            }, // Heroin
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Honey"
                },
                AntiColaModel = true,
                BackfireChance = 0.00f,
                DrinkMessage = "Mmm... Sweet.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Honey
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Hot",
                    "Warm"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "The liquid stings your mouth, it is very hot.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Hot
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Hot Tea",
                    "Tea",
                    "Green Tea",
                    "Black Tea",
                    "Yellow Tea"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "It's too hot!",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Hot Tea
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Hydroflouric Acid",
                    "Hydrochloric Acid",
                    "Corrosive Acid"
                },
                KillPlayer = true,
                KillPlayerString = "Drank Acid that Melted your Internal Organs.",
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "You shouldn't have drunken that acid.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Hydrochloric Acid
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Ice Cream",
                    "Frozen Yogurt"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "It is vanilla flavored ice cream of a perfectly smooth consistency.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Invigorated,
                        Time = 10,
                        ShouldAddIfPresent = true
                    }
                }
            }, // Ice cream
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Ink"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "You recoil from the powerful odor of the liquid.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 10,
                        ShouldAddIfPresent = true
                    }
                }
            }, // Ink
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Insulin",
                    "NovoRapid",
                    "Novo Rapid",
                    "Glargine"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "It smells strong... but it tastes slightly of milk...",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 10,
                        ShouldAddIfPresent = true
                    }
                }
            }, // Insulin
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Ipecac"
                },
                Tantrum = true,
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "It tastes like tree sap. Your stomach begins trembling soon after consumption.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Exhausted,
                        Time = 20,
                        ShouldAddIfPresent = true
                    }
                }
            }, // Ipecac
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Iron",
                    "Steel",
                    "Metal",
                    "Razor Blades",
                    "Razorblades"
                },
                KillPlayer = true,
                KillPlayerString = "Ingested too much Metal too quickly.",
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "Too much iron...",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Iron
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Jewel of Fire",
                    "Lifeforce",
                    "The Jewel"
                },
                AntiColaModel = true,
                BackfireChance = 0.00f,
                DrinkMessage = "An echoed voice shouts: \"YOU MUST NOT! THE JEWEL HOLDS MY LIFEFORCE!!!\"",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 60,
                        ShouldAddIfPresent = true
                    },
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Bleeding,
                        Time = 60,
                        ShouldAddIfPresent = true
                    }
                }
            }, // Jewel of Fire
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Jimmies",
                    "Rustling",
                    "Gorilla Munch"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "Shh, no tears, only dreams now. There is no need to be upset.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 10,
                        ShouldAddIfPresent = true
                    },
                }
            }, // Jimmies
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Joe",
                    "Joseph",
                    "Cat",
                    "Dog",
                    "Intestines"
                },
                AntiColaModel = true,
                BackfireChance = 0.00f,
                DrinkMessage = "The drink tastes like blood. It's still warm.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Joe/Cat/Dog/Intestines
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Jorge"
                },
                AntiColaModel = true,
                BackfireChance = 0.00f,
                HealAmount = 50,
                HealStatusEffects = true,
                DrinkMessage = "You feel as though someone is expecting you.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 2,
                        ShouldAddIfPresent = true
                    },
                }
            }, // Jorge
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Knowledge"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "Y'know, to end up here, I don't think Knowledge will help much.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Knowledge
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Lava",
                    "Magma",
                    "Earth",
                    "Rock",
                    "Rocks",
                    "Stone"
                },
                KillPlayer = true,
                KillPlayerString = "Tried ingesting magma, didn't go well.",
                AntiColaModel = true,
                BackfireChance = 0.00f,
                DrinkMessage = "The liquid disintegrates your insides almost instantly.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Lava/Magma
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Lemon",
                    "Lemon Juice",
                    "Lemonade"
                },
                AntiColaModel = true,
                BackfireChance = 0.00f,
                DrinkMessage = "Tastes lemon-y...",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Lemonade
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Lemon Fanta"
                },
                AntiColaModel = true,
                BackfireChance = 0.00f,
                DrinkMessage = "Take that! In one gulp, without breathing.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Lemon Fanta
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Life"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                HealStatusEffects = true,
                HealAmount = 150,
                DrinkMessage = "The drink tastes unlike anything you've drunk before. You feel better than ever.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 10,
                        ShouldAddIfPresent = true
                    },
                }
            }, // Life
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Liquid Hydrogen",
                    "Hydrogen",
                    "Liquid Nitrogen",
                    "Nitrogen",
                    "Love"
                },
                KillPlayer = true,
                KillPlayerString = "Had their Heart Frozen Forever",
                AntiColaModel = true,
                BackfireChance = 0.00f,
                DrinkMessage = "Your heart freezes over...",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Liquid Hydrogen/Nitrogen + Love
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Mayo",
                    "Butter"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "Much worse as a drink...",
                DrinkEffects = new List<DrinkEffect>(){
                    
                }
            }, // Mayo/Butter
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Meme",
                    "Memes",
                    "Maymays"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "Me gusta this drink xD le epic taste",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 10,
                        ShouldAddIfPresent = true
                    },
                }
            }, // Memes
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Mercury",
                    "Quicksilver",
                    "Quick Silver"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "The drink is thick like cream, and burns your throat.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 50,
                        ShouldAddIfPresent = true
                    },
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Bleeding,
                        Time = 180,
                        ShouldAddIfPresent = true
                    },
                }
            }, // Mercury/Quicksilver
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Microwave Casserole"
                },
                AntiColaModel = true,
                Tantrum = true,
                BackfireChance = 0.00f,
                DrinkMessage = "Through a complex series of thoughts and inside events, you feel that this belongs to someone else.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 60,
                        ShouldAddIfPresent = true
                    },
                }
            }, // Microwave Casserole
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Milk"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "Mmmm... Milky smooth.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Milk
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Molasses",
                    "Treacle",
                    "Black Treacle"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "The flavor is tangy and sweet, but a little too much for your liking.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 60,
                        ShouldAddIfPresent = true
                    },
                }
            }, // Molasses
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Monkey Island Grog"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "A pirate I was meant to be, trim the sails and roam the sea! Unfortunately, as you start feeling a terrible burning sensation in your throat and stomach, you realize you're actually not used to drinking such heavy stuff …",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 30,
                        ShouldAddIfPresent = true
                    },
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.CardiacArrest,
                        Time = 30,
                        ShouldAddIfPresent = true
                    },
                }
            }, // Monkey Island Grog
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Motor Oil",
                    "Oil"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "Yuck! Should have given this to the military vehicles...",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 10,
                        ShouldAddIfPresent = true
                    },
                }
            }, // Motor Oil
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Mountain Dew"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "It's nice and cold.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Mountain Dew
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Mucus"
                },
                Tantrum = true,
                AntiColaModel = true,
                BackfireChance = 0.00f,
                DrinkMessage = "Why the hell would I want to drink this?",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Mucus
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Mud",
                    "Clay"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "The liquid has a dirty taste...",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 3,
                        ShouldAddIfPresent = true
                    },
                }
            }, // Mud/Clay
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Nausea"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                Tantrum = true,
                DrinkMessage = "Ugg... I don't feel so good...",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.CardiacArrest,
                        Time = 5,
                        ShouldAddIfPresent = true
                    },
                }
            }, // Nausea
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Orange Fanta",
                    "Orangina"
                },
                AntiColaModel = true,
                BackfireChance = 0.00f,
                DrinkMessage = "That tastes good...",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Orange Fanta
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Orange Juice",
                    "Orange"
                },
                AntiColaModel = true,
                BackfireChance = 0.00f,
                DrinkMessage = "The drink tastes sweet and has quite a bit of pulp.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Orange Juice
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Pain",
                    "Agony"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "The drink tastes incredibly bitter. You feel a burning pain in your stomach.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.CardiacArrest,
                        Time = 15,
                        ShouldAddIfPresent = true
                    },
                }
            }, // Pain / Agony
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Perfume",
                    "Deoderant",
                    "Shampoo",
                    "Cologne",
                    "Fragrance"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "While it does smell lovely, I'd rather wear it than drink it.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Perfume
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Pina Colada"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "Cold and sweet.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Pina Colada
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Plastic"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "The molten plastic burns your mouth.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 2,
                        EffectType = EffectType.Blinded,
                        Time = 2,
                        ShouldAddIfPresent = true
                    },
                    new DrinkEffect() {
                        EffectAmount = 2,
                        EffectType = EffectType.Bleeding,
                        Time = 10,
                        ShouldAddIfPresent = true
                    },
                }
            }, // Plastic
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Prune Juice"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "Pretty pruny... Not Bad.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Prune Juice
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Purple Drank",
                    "Sizzurp",
                    "Codeine",
                    "Lean"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "The drink tastes like cough syrup.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 100,
                        ShouldAddIfPresent = true
                    },
                }
            }, // Purple Drank / LEAN
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Pus"
                },
                Tantrum = true,
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "It's too hot!",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 15,
                        ShouldAddIfPresent = true
                    },
                }
            }, // Pus
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Radioactive Element",
                    "Radioactive Material"
                },
                KillPlayer = true,
                KillPlayerString = "Body was found with high traces of Radioactivity.",
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "You feel very sick, and collapse to the floor.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Radioactive Element
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Rage",
                    "Anger",
                    "Angry",
                    "Hate"
                },
                KillPlayer = true,
                KillPlayerString = "Hated everything in the world so much that it killed them",
                AntiColaModel = true,
                BackfireChance = 0.00f,
                DrinkMessage = "Your blood boils with overwhelming hatred towards everything.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Rage
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Room-Temperature Superconductor"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "The drink tastes like apple juice",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Room-Temperature Superconductor
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Sadness",
                    "Unhappiness",
                    "Mourning",
                    "Grieving"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "The warm liquid has a salty after-taste, almost like tears.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Sadness
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "SCP 294",
                    "SCP-294",
                    "294",
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "On the side of the empty cup there are complex blueprints. They contain an untranslatable language and indecipherable diagrams.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // SCP-294
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Sea Water",
                    "Saline Water",
                    "Salt Water"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "The extremely salty taste is almost unbearable. You begin to feel dehydrated and dizzy.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 4,
                        ShouldAddIfPresent = true
                    },
                }
            }, // Sea Water
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Semen",
                    "Cum",
                    "Jizz",
                    "Man Milk",
                    "Baby Batter",
                    "Joy Juice",
                    "Cock Snot",
                    "Load",
                    "Man Chowder",
                    "Wad",
                    "9gag"
                },
                Tantrum = true,
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "No way.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Semen / CUM!!!
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Smoothie"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "It is a delicious blueberry and banana smoothie.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Smoothie
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Something that will destroy SCP-682",
                    "Something that destroys SCP-682",
                    "Something to destroy SCP-682"
                },
                Explode = true,
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "Uh oh.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Something to destroy SCP-682
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Spinal Fluid",
                    "Brain Juice",
                    "Brain Fluid"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "It is mildly salty, tepid, and watery. I shouldn't really be drinking this.",
                DrinkEffects = new List<DrinkEffect>(){
                    
                }
            }, // Spinal Fluid
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Spoiler",
                    "Spoilers",
                    "Spoiling"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "You hear a voice inside your head.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Spoiler
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Stew"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "It is a scrumptious, warm, and creamy mushroom stew.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 10,
                        ShouldAddIfPresent = true
                    },
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Invigorated,
                        Time = 20,
                        ShouldAddIfPresent = true
                    },
                }
            }, // Stew
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Strawberry Juice"
                },
                AntiColaModel = true,
                BackfireChance = 0.00f,
                DrinkMessage = "So sweet.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Strawberry Juice
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Speed",
                    "Velocity",
                    "Fastness",
                    "Sanic"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "You feel really nervous.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 15,
                        ShouldAddIfPresent = true
                    },
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Invigorated,
                        Time = 15,
                        ShouldAddIfPresent = true
                    },
                }
            }, // Speed
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Stearin",
                    "Stearine"
                },
                AntiColaModel = true,
                BackfireChance = 0.00f,
                DrinkMessage = "HOT! HOT! HOT!",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 2,
                        ShouldAddIfPresent = true
                    },
                }
            }, // Stearine
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Strange Matter",
                    "Sulfuric Acid",
                    "Superfluid",
                    "Superfluid Helium",
                    "Liquid Helium",
                    "Helium",
                    "Helium-4"
                },
                AntiColaModel = false,
                KillPlayer = true,
                KillPlayerString = "Ingested a horrible substance with a horrible smell",
                BackfireChance = 0.00f,
                DrinkMessage = "Tasted horrible. Your insides couldn't agree more.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Strange Matter, Sulfuric Acid, Superfluid Helium
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Surprise",
                    "Surprise Me",
                    "Shock",
                    "Shock Me"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "The water burns your mouth instantly.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 2,
                        ShouldAddIfPresent = true
                    },
                }
            }, // Surprise/Shock me
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Syrup",
                    "Golden Syrup",
                    "Maple Syrup"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "While irresistibly sweet, you become overpowered by the sweetness to the point of nausea.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 7,
                        ShouldAddIfPresent = true
                    },
                }
            }, // Syrup
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Ice Tea",
                    "Tea"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "It tastes like cold tea.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Cold Tea
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Tears",
                    "Tear",
                    "Saliva",
                    "Spit",
                    "Sweat"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "Tastes salty...",
                DrinkEffects = new List<DrinkEffect>(){
                }
            }, // Tears/Spit
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Tequila"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "Could've used some lime and salt with that.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Tequila
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "The best drink I've ever had",
                    "The best drink I've had"
                },
                AntiColaModel = true,
                BackfireChance = 0.00f,
                DrinkMessage = "The drink tastes like a Vienna lager you drinked years ago.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // The best drink I've ever had
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "The Perfect Drink",
                    "Perfect Drink",
                    "Perfection"
                },
                KillPlayer = true,
                KillPlayerString = "Had a taste of perfection, and drifted into depression.",
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "I can't take this anymore, everything at this point is just one big letdown.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Perfect Drink
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Tropical Juice",
                    "Tropical Water"
                },
                AntiColaModel = true,
                BackfireChance = 0.00f,
                DrinkMessage = "The chilled orange beverage tastes like a combination of tropical fruits.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Tropical Juice
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Tomato Juice"
                },
                AntiColaModel = true,
                BackfireChance = 0.00f,
                DrinkMessage = "Meh, it's ok. Never was a big fan of tomato juice though.",
                DrinkEffects = new List<DrinkEffect>(){
                    
                }
            }, // Tomato Juice
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Urine",
                    "Piss",
                    "Pee",
                    "Jarate"
                },
                Tantrum = true,
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "I'm not drinking that.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Urine / PISS!!!
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Venom",
                    "Snake Venom"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "You feel a little queasy, but the venom seems to be weak.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.CardiacArrest,
                        Time = 8,
                        ShouldAddIfPresent = true
                    },
                }
            }, // Venom
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Vidya",
                    "V",
                    "4chan"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "The drink tastes awfully bitter.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // 4chan/Vidya
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Vinegar"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "Ugh, not a great choice to drink alone.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 10,
                        ShouldAddIfPresent = true
                    },
                }
            }, // Vinegar
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Vomit"
                },
                Tantrum = false,
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "I'm not drinking that.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Vomit
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Wax",
                    "Grease"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "The taste makes you feel ill.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 5,
                        ShouldAddIfPresent = true
                    },
                }
            }, // Wax/Grease
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Wine",
                    "Red Wine",
                    "Grape Wine"
                },
                AntiColaModel = true,
                BackfireChance = 0.00f,
                DrinkMessage = "Tastes like a slightly above-average wine.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Wine
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Whisky",
                    "Whiskey",
                    "Scotch"
                },
                AntiColaModel = true,
                BackfireChance = 0.00f,
                DrinkMessage = "Tastes like a slightly above-average whiskey.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Whiskey
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "White Port and Lemon Juice",
                    "WPLJ"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "Please please please gimme some more",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // White Port and Lemon Juice
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "420",
                    "Weed",
                    "Dope",
                    "Green Dragon"
                },
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "MAN DATS SOM GOOD ASS SHIT",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Blinded,
                        Time = 60,
                        ShouldAddIfPresent = true
                    },
                    new DrinkEffect() {
                        EffectAmount = 1,
                        EffectType = EffectType.Invigorated,
                        Time = 60,
                        ShouldAddIfPresent = true
                    }
                }
            }, // 420 WEED !!!!
        };

        public static List<CustomDrink> CommunityDrinks = new List<CustomDrink> {
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Pink",
                    "Pink Candy",
                    "PinkCandy",
                    "C4"
                },
                AntiColaModel = true,
                BackfireChance = 0.25f,
                ExplodeOnBackfire = true,
                DrinkMessage = "It had a strong strawberry flavor. My stomach hurts...",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Scp207,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.AntiScp207,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    }
                }
            }, // Pink Candy Drink
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Old",
                    "Old Age",
                    "Grandpa",
                    "Grandfather",
                    "Geezer",
                    "What",
                    "What?"
                },
                AntiColaModel = false,
                BackfireChance = 0f,
                DrinkMessage = "WHAT? WHAT DID YOU SAY SONNY?",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Deafened,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Blinded,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    }
                }
            }, // Old Age
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "SCP-009",
                    "SCP009",
                    "009",
                    "SCP-9",
                    "9",
                    "Red Ice",
                    "RedIce"
                },
                AntiColaModel = true,
                BackfireChance = 0f,
                DrinkMessage = "You feel something Crystalize on your tongue...",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect()
                    {
                        EffectType = EffectType.CardiacArrest,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    }
                }
            }, // Red Ice / SCP-009
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Grimace",
                    "GrimaceShake",
                    "Grimace Shake"
                },
                AntiColaModel = true,
                BackfireChance = 0f,
                DrinkMessage = "Happy Birthday Grimace!... I feel strange...",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Corroding,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 60
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.AmnesiaItems,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 60
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Blinded,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 10
                    }
                }
            }, // Grimace Shake
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Medusa",
                    "Statue",
                    "Sculpture"
                },
                AntiColaModel = false,
                BackfireChance = 0f,
                DrinkMessage = "You feel yourself turning brittle, then you feel nothing at all.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect()
                    {
                        EffectType = EffectType.DamageReduction,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 3
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.AmnesiaItems,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 3
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Blinded,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 3
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Ensnared,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 3
                    }
                }
            }, // Medusa
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "craziness",
                    "crazy",
                    "crazy?",
                    "insanity",
                    "insane",
                    "rubber room",
                    "rat",
                    "rats",
                    "rubber rat",
                    "rubber rats"
                },
                AntiColaModel = false,
                BackfireChance = 0f,
                DrinkMessage = "Crazy? I was crazy once. They locked me in a room. A rubber room. A rubber room with rats, and rats make me crazy. Crazy? I was crazy once. They locked me in a room. A rubber room. A rubber room with rats, and rats make me crazy. Crazy? I was crazy once. They locked me in a room. A rubber room. A rubber room with rats, and rats make me crazy. Crazy? I was crazy once. They locked me in a room. A rubber room. A rubber room with rats, and rats make me crazy.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect()
                    {
                        EffectType = EffectType.SeveredHands,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.SinkHole,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    }
                }
            }, // Crazy? I was Crazy once.
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Boykisser",
                    "Boykissing",
                    "Boykiss",
                    "Boy Kisser",
                    "Boy Kissing",
                    "Boy Kiss",
                    "Kissing Boys",
                    "Kiss Boys",
                    "Kissing Boy",
                    "Kiss Boy"
                },
                AntiColaModel = false,
                BackfireChance = 0f,
                DrinkCallback = DrinkCallbacks.Boykisser,
                DrinkMessage = "You like kissing boys, dont you! Youre a silly little boykisser! OwO",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Boykisser
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Anabolic Steroid",
                    "Anabolic Steroids",
                    "Steroids",
                    "Steroid",
                    "Green Juice",
                    "GreenJuice",
                    "SCP-1853",
                    "SCP1853",
                    "1853",
                    "GoblinJuice",
                    "Goblin Juice"
                },
                AntiColaModel = false,
                BackfireChance = 0f,
                DrinkMessage = "Your stomach churns as you drink the liquid, and you feel your blood pumping faster than ever. This may have been a bad idea...",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Scp1853,
                        EffectAmount = 255,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Invigorated,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Poisoned,
                        EffectAmount = 3,
                        ShouldAddIfPresent = true,
                        Time = 0
                    }
                }
            }, // Anabolic Steroid / GREEN JUICE
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "SCP-268",
                    "SCP268",
                    "268",
                    "Invisibility",
                    "Camoflague",
                    "Camouflague",
                    "Camo",
                    "Invisible",
                    "Transparency",
                    "Transparent",
                    "Camoflavor",
                    "Camouflavor",
                    "Camoflavour",
                    "Camouflavour"
                },
                AntiColaModel = false,
                BackfireChance = 0f,
                DrinkMessage = "It's like I'm not even here...",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Invisible,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 15
                    }
                }
            }, // Hat / Invisibility
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "SCP500",
                    "SCP-500",
                    "500"
                },
                HealAmount = 100,
                HealStatusEffects = true,
                AntiColaModel = true,
                BackfireChance = 0.25f,
                DrinkMessage = "Tastes like a cough syrup. You suddenly feel a lot better.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // SCP-500
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "SCP-999",
                    "SCP999",
                    "999"
                },
                HealAmount = 100,
                HealStatusEffects = true,
                AntiColaModel = false,
                BackfireChance = 0.00f,
                DrinkMessage = "You feel a lot happier, and your wounds begin healing. Though, you feel as if there was something moving in your stomach.",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Invigorated,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 45
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Poisoned,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 45
                    }
                }
            }, // SCP-999
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "SCP-2521",
                    "SCP2521",
                    "2521",
                    "../...../../.",
                    "SCP../...../../.",
                    "SCP-../...../../."
                },
                HealAmount = 100,
                HealStatusEffects = true,
                AntiColaModel = false,
                BackfireChance = 0.00f,
                KillPlayer = true,
                KillPlayerString = "Taken by ../...../../.",
                DrinkMessage = "../...../../.",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // SCP-2521 ../...../../.
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Almost Instant Death Juice",
                    "Almost Death Juice",
                    "Almost Instant Dead Juice",
                    "Almost Dead Juice",
                    "Kill-Me-Soon",
                    "Kill Me Soon",
                    "KillMeSoon"
                },
                AntiColaModel = true,
                BackfireChance = 0.65f,
                DrinkMessage = "Yep, I sure am <i>almost</i> dead...",
                DrinkEffects = new List<DrinkEffect>(){

                },
                DrinkCallback = DrinkCallbacks.AlmostDeadJuice
            }, // Almost Dead Juice
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Tryhard",
                    "Ghostz",
                    "Cola Addict",
                    "Try hard",
                    "Trying hard",
                    "Pro",
                    "Hardtry"
                },
                AntiColaModel = false,
                BackfireChance = 80f,
                DrinkMessage = "I feel like killling innocent D Bois...",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Scp207,
                        EffectAmount = 4,
                        ShouldAddIfPresent = true,
                        Time = 0
                    }
                },
                ExplodeOnBackfire = true,
                DrinkCallback = DrinkCallbacks.Tryhard
            }, // Tryhard/Ghostz
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Everything",
                    "Everything but the Kitchen Sink",
                    "Everything but the Sink",
                    "Everything but Sink",
                    "Everything but Kitchen Sink",
                    "All",
                    "All but the Kitchen Sink",
                    "All but the Sink",
                    "All but Sink",
                    "All but Kitchen Sink"
                },
                AntiColaModel = false,
                BackfireChance = 85f,
                ExplodeOnBackfire = true,
                DrinkMessage = "<color=#000><size=50>Everything but the S I N K\nEverything but the S I N K\nEverything but the S I N K\nEverything but the S I N K\nEverything but the S I N K\nEverything but the S I N K\nEverything but the S I N K\nEverything but the S I N K\nEverything but the S I N K\nEverything but the S I N K\nEverything but the S I N K\nEverything but the S I N K\nEverything but the S I N K\nEverything but the S I N K\nEverything but the S I N K\nEverything but the S I N K\nEverything but the S I N K\nEverything but the S I N K\nEverything but the S I N K\nEverything but the S I N K\nEverything but the S I N K</size></color>",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect()
                    {
                        EffectType = EffectType.AmnesiaItems,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.AmnesiaVision,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.AntiScp207,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Asphyxiated,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Bleeding,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Blinded,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.BodyshotReduction,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Burned,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.CardiacArrest,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Concussed,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Corroding,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.DamageReduction,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Deafened,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Disabled,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Ensnared,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Exhausted,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Flashed,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Hemorrhage,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Hypothermia,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.InsufficientLighting,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Invigorated,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Invisible,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.MovementBoost,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Poisoned,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.RainbowTaste,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Scanned,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Scp1853,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Scp207,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.SeveredHands,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.SinkHole,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.SoundtrackMute,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Stained,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Traumatized,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    },
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Vitality,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 0
                    }
                }
            }, // Everything but the Kitchen Sink
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "SCP-018",
                    "SCP018",
                    "018",
                    "18",
                    "Ball",
                    "Balls"
                },
                AntiColaModel = true,
                BackfireChance = 0.99f,
                DrinkMessage = "Suddenly, as you drink the liquid, instances of SCP-018 fly out!!!",
                DrinkEffects = new List<DrinkEffect>(){

                },
                DrinkCallback = DrinkCallbacks.BallSpam
            }, // SCP-018
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Kidney Stones",
                    "KidneyStones",
                    "Kidney",
                    "Explosive Stones",
                    "ExplosiveStones",
                    "ExplosiveKidney",
                    "Explosive Kidney",
                    "Explosive Kidney Stones",
                    "ExplosiveKidneyStones"
                },
                AntiColaModel = true,
                BackfireChance = 0.99f,
                DrinkMessage = "Rapidly, Kidney stones start flying out from the cup!!!",
                DrinkEffects = new List<DrinkEffect>(){
                    new DrinkEffect()
                    {
                        EffectType = EffectType.Blinded,
                        EffectAmount = 1,
                        ShouldAddIfPresent = true,
                        Time = 3
                    }
                },
                DrinkCallback = DrinkCallbacks.BallSpam
            }, // Kidney Stones
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Small",
                    "Smallness",
                    "Shrink",
                    "Shrinking",
                    "Tiny",
                    "Smol",
                    "Smoll",
                    "Small Drink",
                    "SmallDrink",
                    "TinyDrink",
                    "Timy Drink"
                },
                AntiColaModel = false,
                BackfireChance = 0f,
                DrinkMessage = "You suddenly feel a little smaller...",
                DrinkEffects = new List<DrinkEffect>(){

                },
                DrinkCallback = DrinkCallbacks.Shrink
            }, // Small Drink
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Big",
                    "Bigness",
                    "Grow",
                    "Growing",
                    "Large",
                    "Growth",
                    "Big Drink",
                    "Large Drink",
                    "BigDrink",
                    "LargeDrink"
                },
                AntiColaModel = false,
                BackfireChance = 0f,
                DrinkMessage = "You suddenly feel a little larger...",
                DrinkEffects = new List<DrinkEffect>(){

                },
                DrinkCallback = DrinkCallbacks.Grow
            }, // Big Drink
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Thin",
                    "Thinness",
                    "Skinny",
                    "Thinning",
                    "Lanky"
                },
                AntiColaModel = false,
                BackfireChance = 0f,
                DrinkMessage = "You suddenly feel a little thinner...",
                DrinkEffects = new List<DrinkEffect>(){

                },
                DrinkCallback = DrinkCallbacks.Thin
            }, // Small Drink
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Fat",
                    "Wide",
                    "Chubby",
                    "Chonk",
                    "Widen",
                    "Wideness",
                    "Wider",
                    "Fatter",
                    "Fatness",
                    "Fattening",
                    "Fatten"
                },
                AntiColaModel = false,
                BackfireChance = 0f,
                DrinkMessage = "You suddenly feel a little wider...",
                DrinkEffects = new List<DrinkEffect>(){

                },
                DrinkCallback = DrinkCallbacks.Wide
            }, // Big Drink
            new CustomDrink()
            {
                DrinkNames = new List<string>(){
                    "Soup",
                    "Rip Soup",
                    "RipSoup"
                },
                AntiColaModel = false,
                BackfireChance = 0f,
                DrinkCallback = DrinkCallbacks.RipSoup,
                DrinkMessage = "RIP Soup, Fly High, Friend...",
                DrinkEffects = new List<DrinkEffect>(){

                }
            }, // Rest in peace, Soup
        };
    }
}

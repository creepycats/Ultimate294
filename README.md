[![Github All Releases](https://img.shields.io/github/downloads/creepycats/Ultimate294/total.svg)](https://github.com/creepycats/Ultimate294/releases) [![Maintenance](https://img.shields.io/badge/Maintained%3F-yes-green.svg)](https://github.com/creepycats/Ultimate294/graphs/commit-activity) [![GitHub license](https://img.shields.io/github/license/Naereen/StrapDown.js.svg)](https://github.com/creepycats/Ultimate294/blob/main/LICENSE)
<a href="https://github.com/creepycats/Ultimate294/releases"><img src="https://img.shields.io/github/v/release/creepycats/Ultimate294?include_prereleases&label=Release" alt="Releases"></a>
<a href="https://discord.gg/PyUkWTg"><img src="https://img.shields.io/discord/656673194693885975?color=%23aa0000&label=EXILED" alt="Support"></a>

# Ultimate294 - The True SCP-294 Experience
Ultimate294 is a plugin that adds a randomly spawning Anomalous Drinks Vending Machine to SCP: Secret Laboratory.

This Recreation Features:
- SCP-294 Model Recreation
- Controllable Spawn Locations
- Usage Limit Control
- *Sound and Animation* for Dispensing Drinks
- **100+ Unique Drinks (Double that for the different Names) ported from Containment Breach, including custom drinks from the Banana's Bungalow community**
- Silly Secret Commands :3

Made for `v13.3.1` of SCP:SL and `v8.4.2` of Exiled and onward by creepycats.

## How It Works
At the beginning of the round, SCP-294 machine(s) will spawn randomly around the map, defaulting to certain rooms of Entrance Zone.

When a player approaches the machine, they will see a pop-up Hint, informing them to hold out a coin and run the `.scp294` command.

If a player holds a coin next to SCP-294, they will be able to run the command `.scp294 <drink>`, which will cause the drink to dispense from the machine. `<drink>` is replaced with the name for whatever drink the player wishes to order.

Unique drink names can be entered, resulting in various effects, events, and modifiers being applied.

Drinks have a set chance to backfire, which will result in the player's drink pouring out their blood, giving them Cardiac Arrest for a few seconds, generally non-fatal, but very harsh.
Better drinks are more likely to result in backfires.

Players can also get a Cup of another Player's blood, if they use the command `.scp294 player <playername>`, replacing `<playername>` with the aforementioned player's name.
This can be used to kill camping players in the event that nobody can reach them, provided the players find coins and know the player's name.

Some drinks have been given SCP:SL Twists in comparison to their Containment Breach counterparts. For example, order something gross, and you might end up pouring the drink on the floor (Spawning a Tantrum puddle)

## Admin Commands
Administrators with the `SCP294.admin` permission have access to the RA command `scp294`:
-`scp294 create/spawn` > Spawns a new SCP-294 machine at the player's coordinates.
-`scp294 remove/delete` > Deletes the closest SCP-294 machine to the player.
-`scp294 setuses <#>` > Sets the number of uses left on the SCP-294 Machine instance nearest to the player. Set to -1 for infinite uses, or 0 for disabled.
-`scp294 givedrink <drink>` > Gives the player the drink that would have been given to them from SCP-294 for free into their inventory.

## Installation
**This Plugin Requires MapEditorReborn, [you can download it here](https://github.com/Michal78900/MapEditorReborn/releases)**

**This Plugin Requires SCPSLAudioApi, [you can download it here](https://github.com/CedModV2/SCPSLAudioApi/releases)**

After you've installed MapEditorReborn and SCPSLAudioApi, go to [Releases](https://github.com/creepycats/Ultimate294/releases) and download the latest ZIP file.

Extract the Zip, put `Ultimate294.dll` in your Plugins folder, and Paste the `Config` folder into your `EXILED` folder (which installs my custom Schematic and the sound files)

## Permissions
`SCP294.admin`

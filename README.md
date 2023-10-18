# TrackerModelSwapper

A [ResoniteModLoader](https://github.com/resonite-modding-group/ResoniteModLoader) mod for [Resonite](https://resonite.com/) that allows you to replace the vive tracker model used to visualize trackers.

## ⚠️ WARNING ⚠️

Because of how the game loads objects you MUST save the object through the inspector AND the local position and rotation of the saved object is significant, it's recommended to keep the position at `0,0,0`, and the `Z` axis should be the forward direction on your tracker.

Additionally it is recommended to keep the naming scheme similar to the original, because some user made tools search for the vive tracker objects by name.

## Installation
1. Install [ResoniteModLoader](https://github.com/resonite-modding-group/ResoniteModLoader).
1. Place [TrackerModelSwapper.dll](https://github.com/art0007i/TrackerModelSwapper/releases/latest/download/TrackerModelSwapper.dll) into your `rml_mods` folder. This folder should be at `C:\Program Files (x86)\Steam\steamapps\common\Resonite\rml_mods` for a default install. You can create it if it's missing, or if you launch the game once with ResoniteModLoader installed it will create the folder for you.
1. Start the game. If you want to verify that the mod is working you can check your Resonite logs.

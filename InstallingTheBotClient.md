# Introduction #

```
With BWAPI 2.8 and up, it is now possible to run a bot as a separate process which can still use BWAPI.
This is done with shared memory and must be run on the same computer as starcraft.
bwapi-mono-bridge is also compatible with this method.
```

This is a quick guide to setting up the BWAPIClient based bot.

# Details #

  1. Follow all directions for obtaining and setting up the BWAPI 3.5.4 http://code.google.com/p/bwapi/wiki/UsingBWAPI
  1. Download the zip file from the downloads tab
  1. Extract the zip to a new folder
  1. open the StarcraftBot solution from the starcraftbot folder with vs 2008 sp1
  1. edit the references of the starcraftbot project and remove bwapi-clr.dll and starcraftbotlib.dll
  1. add references to starcraftbotlib.dll and bwapi-clr.dll from the libs\client folder
  1. compile the project
  1. Copy everything from the libs\client folder and place them into bwapi-data\ai in your starcraft folder. (this is not essential, the bot can be run from anywhere on your system, as long as the required files are in the same place)
  1. copy starcraftbot.dll from your project bin folder to the bwapi-data\AI folder

# Running the Bot #
To run the bot:
  1. launch the ClrAiModuleLoader by running ClrAiModuleLoader.exe (it should say connecting...)
  1. launch starcraft on the same computer (the bot should now say "waiting for match")
  1. start a custom match against the computer.
  1. the bot should print some stuff to the screen etc.
# Introduction #

This is a quick walkthrough of installing the bwapi-mono-bridge skeleton AI in embedded mode (running in the same process as starcraft).


# Details #

  1. Follow all directions for obtaining and setting up the BWAPI 3.5.4 http://code.google.com/p/bwapi/wiki/UsingBWAPI
  1. Download the zip file from the downloads tab
  1. Extract the zip to a new folder
  1. open the StarcraftBot solution from the starcraftbot folder with vs 2008 sp1
  1. edit the references of the starcraftbot project and remove bwapi-clr.dll and starcraftbotlib.dll
  1. add references to starcraftbotlib.dll and bwapi-clr.dll from the libs\embedded\bot folder
  1. compile the project
  1. copy the contents of the libs\embedded folder into the bwapi-data\AI folder in your starcraft directory (created during BWAPI setup)
  1. copy starcraftbot.dll from your project bin folder to bwapi-data\AI\bot folder
  1. Edit the bwapi.ini file and change the ai\_dll line to read:
```
[ai]
ai = bwapi-data\AI\MonoBridge.dll
```
  1. Make sure mono 2.8 or above is installed on your computer www.go-mono.com
  1. set an environment variable called "MonoPath" with its value being the path to the Mono's bin folder eg "C:\program files\Mono-2.8\bin" (Hint right click my computer->properties->advanced->environment variables->add)

You are ready to run the bot. Just run chaoslauncher as per usual and the bot should see a message from the bot when it starts up. (if it isn't working then broodwar will crash, try checking log file to see the problem)

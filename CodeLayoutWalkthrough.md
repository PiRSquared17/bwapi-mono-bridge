# Introduction #

This is a quick layout of the source structure for the project

**NOTE** if you are compiling on x64, ensure all projects are set to x86

# Details #
Common
  * Contains the header and lib files needed from the BWAPI and BWTA projects (see code.google.com)
  * Also contains the SWIG interface files needed to generate the interface between mono/.net and c++
  * Contains all the generated Swig classes
  * Contains the definition of IStarcraftBot

bwapi-clr-client
> Source for the BWAPIClient client/server based bot/interface
    * bwapi-clr
      * The BWAPI library exposed as .net/mono classes
    * bwapi-native
      * Native c++ project that includes the BWAPI and BWTA libraries and exposes them for use by bwapi-clr
    * testbot
      * A quick example of directly using the BWAPI and BWTA via the client/server functions (.net/mono)
    * clrAIModuleLoader
      * A project that will load bots that implement IStarcraftBot (from bwapi-clr). These bots are more similiar to the embedded BWAPI style AI Modules


bwapi-clr-embedded
> Source for the BWAPI embedded AIModule based bot/interface
    * bwapi-clr
      * The BWAPI library exposed as .net/mono classes (exactly the same as bwapi-clr from the bwapi-clr-client project except references internal instead of bwapi.dll
    * MonoBridge
      * Native c++ project that includes the BWAPI and BWTA libraries and exposes them for use by bwapi-clr.
      * Loads MonoBridgeAI .net assembly via a copy of the mono runtime embedded in the starcraft process
    * MonoBridgeAI
      * Loads the bot ai from the dll specified in the monobridgeai.config file. Bot must implement IStarcraftBot (declared in monobridgeai-interop)

Release
> Files for packaging
    * libs
      * contains the libs for the embedded and client bots
    * StarcraftBot
      * Source for a bot that implements IStarcraftBot interface and can be loaded by either the in process MonoBridgeAI or client/server bwapi-clr-client\clrAILModuleLoader
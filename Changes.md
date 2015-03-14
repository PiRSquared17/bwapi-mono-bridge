## Changes in 3.5a ##
  * compatible with BWAPI 3.5.4 beta
  * Embedded bot still crashes on game restart. Use client mode.

## Changes in 3.4a ##
  * compatible with BWAPI 3.4 beta
  * Embedded bot still crashes on game restart. Use client mode.

## Changes in 3.3b ##
  * Added starcraftclient project to release, this is a bot that deals with the bwapi-clr directly and doesn't implement IStarcraftBot. This was missing from the last release
  * Changed projects to compile to x86 to prevent problems on 64bit computers

## Changes in 3.3a ##
  * Compatible with version 3.3 beta of BWAPI
  * BWAPI, BWTA and BWAPIC namespaces are now in the SWIG namespace
  * Project Source restructure for quicker updates and more shared code between client and embedded.


## Changes in 3.2b ##
  * Changed bwapi-clr and testbot project to be x86 only, so that they work on x64 systems.
  * Re-added monobridgeai.dll.config to the example embedded bot.
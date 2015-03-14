# Introduction #

**UPDATED 28/04/2011**

  * Now supports BWAPI 3.5.4!

**Write a starcraft AI in .NET!! (C#, VB.net, Delphi Prism, etc)**

Run your bot either in the same process as broodwar via the embedded libraries or as a client via the client libraries. Both have full access to BWAPI and BWTA. Change from embedded bot to client bot just by changing 2 references.

## Detail ##

This project allows people to write AIs for
Starcraft:Broodwar using the CLR (.Net/Mono) via full integration with the c++ based BWAPI and BWTA.

This allows for creation of bots in most .Net languages with compatibility with the .Net 3.5 runtime.

This bot can be made completely embedded and be executed on a computer without the .Net runtime or mono runtime installed (embedded bots only).

## Usage ##

In the download package there is a starcraftbot folder and a libs folder.
The starcraftbot folder has a starcraftbot implementation to get you started.
The libs folder contains the assemblies for the embedded bot and the client bot.

The requirements for a starcraft bot is that it implements IStarcraftBot (defined in StarcraftBotLib.dll) and references an incarnation of bwapi-clr.dll (the BWAPI and BWTA projects exposed as Managed Classes).

For an out of process bot reference the bwapi-clr.dll and StarcraftBotLib.dll in the libs\client folder.

For an embedded bot reference the bwapi-clr.dll and StarcraftBotLib.dll in the libs\embedded folder

All BWAPI classes are in the SWIG.BWAPI namespace and all global functions are in the SWIG.BWAPI.bwapi class

All BWTA classes are in the SWIG.BWTA namespace and all global functions are in the SWIG.BWTA.bwta class

Once you have coded your bot, you will need to install see InstallingTheBot


# Google Group #
<table cellspacing='0'>
<blockquote><tr><td>
<img src='http://groups.google.com/intl/en/images/logos/groups_logo_sm.gif' /></td></tr>
<tr><td>
<b>bwapi-mono-bridge</b>
</td></tr>
<tr><td>
<a href='http://groups.google.com/group/bwapi-mono-bridge'>Visit this group</a>
</td></tr>
</table></blockquote>


# How Tos #
  * InstallingTheBot


# Known Issues #
  * **In Progress** Improve documentation.
  * No BWSAL. Anyone?

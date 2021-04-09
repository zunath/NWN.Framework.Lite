# NWN.Framework.Lite

NWN.Framework.Lite is an unopinionated framework for writing Neverwinter Nights code in C#.

Its intention is to provide you with minimal structure to your project while being dead simple to learn. We give you what you need to get started and then get out of your way.

- Latest [[Release](https://github.com/zunath/NWN.Framework.Lite/releases/latest)]
- Join the community: [[Discord](https://discord.gg/eVWV49A)]

## Getting Started

1. Find NWN.Framework.Lite on the Nuget feed and install it into your project.

1. Create a class where your code will be written.

1. Create a method like the following

```cs
// This method will be run whenever the script "sit" is run. In our example module, this happens when a player clicks a chair.
// Script names must adhere to the NWN restrictions (alphanumeric with some special characters and no longer than 16 characters)
// The method name is arbitrary and can be called whatever you want.
// Methods must be public and static so that the framework can pick them up when the module loads.
[ScriptHandler("sit")]
public static void SitOnAChair()
{
    var player = NWScript.GetLastUsedBy();
    var chair = NWScript.OBJECT_SELF;
    
    AssignCommand(player, () => ActionSit(chair));
}
```

1. Configure your NWNX server with the following environment variables. Setting up an NWNX server is outside the scope of this guide. More information can be found in the Additional Resources section of this guide.

```cs
NWNX_DOTNET_ASSEMBLY=/nwn/home/dotnet/NWN.Framework.Lite 
NWNX_DOTNET_ENTRYPOINT=NWN.Framework.Lite.Internal
```

1. Add the script "sit" to the OnUsed event of a placeable chair.
1. Build the project and run the NWNX server
1. Log in and click the chair. Your character should sit down.

And that's it!

## Additional Resources

[[NWNX Unified](https://github.com/nwnxee/unified/)] - The NWNX project which has guides on setting up a server.

[[NWN Lexicon](https://nwnlexicon.com/index.php?title=Main_Page)] - Contains a wealth of useful information about NWScript.

[[NWN Managed](https://github.com/nwn-dotnet/NWN.Managed)] - An alternative, opinionated framework.

## Contributing

We welcome all contributions via Pull Request. Please read the following as they serve as our guiding principles on this project. We expect all contributions to adhere to these guidelines.

1. The Lite framework is intended to be exactly as it sounds - light and unobtrusive. There are no fancy frameworks to learn. Install the package and go.
1. We don't provide everything and the kitchen sink. There's some glue code, the NWScript and NWNX methods, and assorted enumerations. On the rare occasion we will also provide conversions of commonly used NWScript functions found in include files.

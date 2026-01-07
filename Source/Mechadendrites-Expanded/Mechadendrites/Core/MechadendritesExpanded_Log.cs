using Verse;
// Resharper disable all

#nullable disable
namespace Mechadendrites.Core;

[StaticConstructorOnStartup]
public static class MechadendritesExpanded_Log
{
    static MechadendritesExpanded_Log()
    {
        Log.Message("[Mechadendrites Expanded Revision: Nova] Loaded");
        Log.Warning("You are running an experimental branch of Mechadendrites Expanded. Proceed with caution");
        Log.Warning("Please report any bugs to https://github.com/Marakshi21/Mechadendrites-Expanded/tree/Nova and leave an issue with a hugslib log");
    }
    
}
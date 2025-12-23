using Verse;

namespace MechadendritesExpanded;

[StaticConstructorOnStartup]
public static class MechadendritesExpanded_Log
{
    static MechadendritesExpanded_Log()
    {
        Log.Message("[Mechadendrites Expanded] Revision: Nova Loaded");
        Log.Error("You are running an experimental branch of Mechadendrites Expanded. Proceed with caution");
    }
    
}
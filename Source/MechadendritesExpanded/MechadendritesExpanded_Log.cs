using Verse;

namespace MechadendritesExpanded
{
    // Print out a log to confirm the mod loaded properly
    [StaticConstructorOnStartup]
    public static class MechadendritesExpanded_Log
    {
        static MechadendritesExpanded_Log()
        {
            Log.Message("[Mechadendrites Expanded] Revision: Nova loaded");
            Log.Error("You are running the Nova Branch of Mechadendrites Expanded. This branch is experimental and unstable. Proceed with caution."); // Remove for main release
        }
    }
}
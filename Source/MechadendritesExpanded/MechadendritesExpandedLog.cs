using Verse;

namespace MechadendritesExpanded
{
    // Print out a log to confirm the mod loaded properly
    [StaticConstructorOnStartup]
    public static class MechadendritesExpandedLog
    {
        static MechadendritesExpandedLog()
        {
            Log.Message("[Mechadendrites Expanded] Revision: Nova loaded");
            Log.Warning("You are running the Nova Branch of Mechadendrites Expanded. This branch is experimental and unstable. Proceed with caution."); // Remove for main release
        }
    }
}
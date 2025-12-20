using Verse;

namespace MechadendritesExpanded
{
    [StaticConstructorOnStartup]
    public static class MechadendritesExpandedLogging
    {
        static MechadendritesExpandedLogging()
        {
            Log.Message("[Mechadendrites Expanded] Revision: Nova loaded");
            Log.Warning("You are running the Nova Branch of Mechadendrites Expanded. This branch is experimental and unstable. Proceed with caution."); // Remove for main release
        }
    }
}
using Verse;

namespace Mechadendrites;

[StaticConstructorOnStartup]
public static class Mechadendrites_Log 
{
    static Mechadendrites_Log()
    {
        Log.Message("[Mechadendrites Expanded] Loaded");
        Log.Warning("This is an in-development build of Mechadendrites Expanded. Bugs are to be expected. Save stability is not guaranteed.");
    }
}
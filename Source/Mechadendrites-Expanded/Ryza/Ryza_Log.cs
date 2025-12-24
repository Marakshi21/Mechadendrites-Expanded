using Verse;

namespace Ryza;

[StaticConstructorOnStartup]
public static class Ryza_Log
{
    static Ryza_Log()
    {
        Log.Message("[Ryza Framework] Initialized");
    }
}
using Verse;
namespace MechadendritesExpanded
{
    [StaticConstructorOnStartup]
    public static class BootupLog
    {
        static BootupLog()
        {
            Log.Message("[Mechadendrites Expanded - Nova] Loaded");
        }
    }
}
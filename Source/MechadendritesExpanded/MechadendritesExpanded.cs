using Verse;
using HarmonyLib;

namespace MechadendritesExpanded
{
    // Instantiate Harmony
    public class MechadendritesExpanded : Mod
    {
        public MechadendritesExpanded(ModContentPack content)
            : base(content)
        {
            new Harmony("dusk.mechadendritesexpanded").PatchAll();
        }
    }
}
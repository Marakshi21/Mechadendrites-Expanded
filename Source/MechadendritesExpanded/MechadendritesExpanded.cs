using Verse;
using System.Reflection;
using HarmonyLib;

namespace MechadendritesExpanded
{
    public class MechadendritesExpanded : Mod
    {
        public MechadendritesExpanded(ModContentPack content)
            : base(content)
        {
            new Harmony("dusk.mechadendritesexpanded").PatchAll();
        }
    }
}
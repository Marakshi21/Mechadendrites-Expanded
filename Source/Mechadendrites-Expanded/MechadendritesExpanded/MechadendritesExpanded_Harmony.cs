using HarmonyLib;
using Verse;
// Resharper disable all

#nullable disable
namespace MechadendritesExpanded;

// Instantiate Harmony
public class MechadendritesExpanded_Harmony : Mod
{
    public MechadendritesExpanded_Harmony(ModContentPack content)
        : base(content)
    {
        new Harmony("dusk.mechadendritesexpanded").PatchAll();
    }
}
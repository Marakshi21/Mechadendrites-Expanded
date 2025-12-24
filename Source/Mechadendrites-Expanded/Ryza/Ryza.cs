using HarmonyLib;
using Verse;

namespace Ryza;

public class Ryza : Mod
{
    public Ryza(ModContentPack content)
        : base(content)
    {
        new Harmony("Dusk.RyzaFramework").PatchAll();
    }
}
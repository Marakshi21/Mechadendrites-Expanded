using Verse;
using HarmonyLib;

namespace Mechadendrites;

public class Mechadendrites : Mod
{
    public Mechadendrites(ModContentPack content)
        : base(content)
    {
        new Harmony("dusk.mechadendrites").PatchAll();
    }
}
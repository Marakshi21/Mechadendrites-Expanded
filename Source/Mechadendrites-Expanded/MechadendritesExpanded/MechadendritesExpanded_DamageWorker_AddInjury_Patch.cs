using HarmonyLib;
using Verse;

// The goal of the patch is to detect if a mechadendrite slot has an implant and if not stop any damage being applied
// The issue is I am not sure how to write out such a patch
// Let alone in a performant manner
// Going dark for now, will return later

namespace MechadendritesExpanded;
/*
[HarmonyPatch(typeof(DamageWorker.DamageResult) , "ApplyToPawn")]
public class MechadendritesExpanded_DamageWorker_AddInjury_Patch
{
    public static void Prefix(DamageWorker __instance, DamageInfo dinfo)
    {
        bool pawn;
    }
}
*/
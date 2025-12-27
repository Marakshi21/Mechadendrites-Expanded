using HarmonyLib;
using Verse;

// The goal of the patch is to detect if a mechadendrite slot has an implant and if not stop any damage being applied
// The issue is I am not sure how to write out such a patch
// Let alone in a performant manner
// Going dark for now, will return later

namespace MechadendritesExpanded;

[HarmonyPatch(typeof(DamageWorker.DamageResult) , "Apply")]
public class MechadendritesExpanded_DamageWorker_AddInjury_Patch
{
    static bool prefix(DamageWorker __instance, DamageInfo __result) // I am bashing my head into a brick wall
    {
        
    }
}

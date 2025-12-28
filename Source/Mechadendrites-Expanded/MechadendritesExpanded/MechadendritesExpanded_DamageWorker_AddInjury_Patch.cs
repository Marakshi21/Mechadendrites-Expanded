using HarmonyLib;
using Verse;
using RimWorld;

// The goal of the patch is to detect if a mechadendrite slot has an implant and if not stop any damage being applied
// The issue is I am not sure how to write out such a patch
// Let alone in a performant manner

namespace MechadendritesExpanded;

[HarmonyPatch(typeof(DamageWorker.DamageResult) , "ApplyToPawn")]
public class MechadendritesExpanded_DamageWorker_AddInjury_Patch {
    static void prefix(DamageWorker __instance, DamageInfo __result) // I am bashing my head into a brick wall
    {
        if Hediff_Implant Dusk_Mechadendrites = true;
            return true;
        else; 
            return false;
    } 
}
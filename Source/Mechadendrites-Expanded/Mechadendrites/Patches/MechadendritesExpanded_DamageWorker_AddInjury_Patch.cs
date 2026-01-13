using HarmonyLib;
using Verse;
using RimWorld;
// Resharper disable all

// The goal of the patch is to detect if a mechadendrite slot has an implant and if not stop any damage being applied
// The issue is I am not sure how to write out such a patch
// Let alone in a performant manner

#nullable disable
namespace Mechadendrites.Patches;

[HarmonyPatch(typeof(DamageWorker) , "ApplyToPawn")]
public class MechadendritesExpanded_DamageWorker_AddInjury_Patch {
    void prefix(DamageWorker __instance, DamageInfo __result) // I give up
    {
    } 
}
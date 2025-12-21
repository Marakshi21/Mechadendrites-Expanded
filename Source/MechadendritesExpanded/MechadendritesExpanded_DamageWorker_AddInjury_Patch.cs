using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using HarmonyLib;
using Verse;
/*
 The following Patch is meant to intercept the DamageWorker and check to see if it's targeting
 a mechadendrite slot that lacks an added body part of some kind
 and if so, do not apply damage onto it
*/
namespace MechadendritesExpanded
{
    /* I think I may be attaching onto the wrong method for what I want to do
    [HarmonyPatch(typeof (DamageWorker.DamageResult), "ApplyDamageToPart")]
    public static class MechadendritesExpanded_DamageWorker_AddInjury_Patch
    {
        private static void Prefix(DamageWorker.DamageResult __result)

        private BodyPartRecord partFromDamageInfo = this.GetExactPartFromDamageInfo(dinfo, pawn);
    }
    */
}
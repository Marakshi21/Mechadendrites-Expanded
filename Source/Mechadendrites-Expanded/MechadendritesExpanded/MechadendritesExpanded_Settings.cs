using UnityEngine;
using Verse;

namespace MechadendritesExpanded;

public class MechadendritesExpanded_Settings : ModSettings
{
    public static bool CustomDamage; // Enable a harmony patch that prevents mechadendrite slots from taking damage

    public static bool OldSlots; //Re-enables the two missing slots for legacy compat reasons

    public static bool HardMode; // Adds on drawbacks to mechadendrites and makes them harder to make and use

    public override void ExposeData()
    {
        base.ExposeData();
        Scribe_Values.Look<bool>(ref MechadendritesExpanded_Settings.CustomDamage, "CustomDamage", false);
        Scribe_Values.Look<bool>(ref MechadendritesExpanded_Settings.OldSlots, "OldSlots", false);
        Scribe_Values.Look<bool>(ref MechadendritesExpanded_Settings.HardMode, "HardMode", false);
    }

    public static void DoSettingsWindowContents(Rect inRect)
    {
        Listing_Standard listingStandard = new Listing_Standard();
        listingStandard.Begin(inRect);
        listingStandard.Label((string)"Dusk.Experimental".Translate());
        listingStandard.Gap();
        listingStandard.CheckboxLabeled((string)"Dusk.CustomDamage".Translate(), ref MechadendritesExpanded_Settings.CustomDamage, (string)"Dusk.CustomDamageTooltip".Translate());
        listingStandard.Gap();
        listingStandard.CheckboxLabeled((string)"Dusk.OldSlots".Translate(), ref MechadendritesExpanded_Settings.OldSlots, (string)"Dusk.OldSlotsTooltip".Translate());
        listingStandard.Gap();
        listingStandard.CheckboxLabeled((string)"Dusk.HardMode".Translate(), ref MechadendritesExpanded_Settings.HardMode, (string)"Dusk.HardModeTooltip".Translate());
        listingStandard.End();
    }
}
using UnityEngine;
using Verse;

namespace MechadendritesExpanded
{
    public class MechadendritesExpanded_Settings : ModSettings
    {
        public static bool CustomDamage = false; // Enables a custom damage worker that will prevent mechadendrite slots from taking damage without an implant installed
        
        public static bool EnableNegatives = false; // Enables drawbacks on Mechadendrites

        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look<bool>(ref MechadendritesExpanded_Settings.CustomDamage, "CustomDamage", false);
            Scribe_Values.Look<bool>(ref MechadendritesExpanded_Settings.EnableNegatives, "EnableNegatives", false);
        }

        public static void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listingStandard = new Listing_Standard();
            listingStandard.Begin(inRect);
            listingStandard.Gap();
            listingStandard.Label((string)"Dusk.Experimental".Translate()); // Flag the settings below as experimental
            listingStandard.Gap();
            listingStandard.CheckboxLabeled((string) "Dusk.CustomDamage".Translate(), ref MechadendritesExpanded_Settings.CustomDamage, (string)"Dusk.CustomDamageTooltip".Translate());
            listingStandard.Gap();
            listingStandard.CheckboxLabeled((string) "Dusk.EnableNegatives".Translate(), ref MechadendritesExpanded_Settings.EnableNegatives, (string)"Dusk.EnableNegativesTooltip".Translate());
            listingStandard.End();
        }
    }
}
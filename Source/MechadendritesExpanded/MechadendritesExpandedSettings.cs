using UnityEngine;
using Verse;

namespace MechadendritesExpanded
{
    public class MechadendritesExpandedSettings : ModSettings
    {
        public static bool CustomDamage = false;
        
        public static bool EnableNegatives = false;

        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look<bool>(ref MechadendritesExpandedSettings.CustomDamage, "CustomDamage", false);
            Scribe_Values.Look<bool>(ref MechadendritesExpandedSettings.EnableNegatives, "EnableNegatives", false);
        }

        public static void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listingStandard = new Listing_Standard();
            listingStandard.Begin(inRect);
            listingStandard.Gap();
            listingStandard.CheckboxLabeled((string) "Dusk.CustomDamage".Translate(), ref MechadendritesExpandedSettings.CustomDamage, (string)"Dusk.CustomDamageTooltip".Translate());
            listingStandard.Gap();
            listingStandard.CheckboxLabeled((string) "Dusk.EnableNegatives".Translate(), ref MechadendritesExpandedSettings.EnableNegatives, (string)"Dusk.EnableNegativesTooltip".Translate());
            listingStandard.End();
        }
    }
}
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
            listingStandard.CheckboxLabeled((string) "CustomDamage".Translate(), ref MechadendritesExpandedSettings.CustomDamage, "Enable a custom damage worker that prevents damage being applied to mechadendrite slots if there's no implant in them.");
            listingStandard.Gap();
            listingStandard.CheckboxLabeled((string) "EnableNegatives".Translate(), ref MechadendritesExpandedSettings.EnableNegatives, "Enable negative side effects on mechadendrites.");
            listingStandard.End();
        }
    }
}
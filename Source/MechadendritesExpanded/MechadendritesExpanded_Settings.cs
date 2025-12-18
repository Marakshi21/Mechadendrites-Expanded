using System;
using UnityEngine;
using Verse;

namespace MechadendritesExpanded
{
    public class MechadendritesExpanded_Settings  : ModSettings
    {
        public static bool flagNegatives = false;
    }
    
    public override void ExposeData()
    {
        base.ExposeData();
        Scribe_Values.Look<bool>(ref MechadendritesExpanded_Settings.flagNegatives, "flagNegatives", false, true);
    }

    public static void DoWindowContents(Rect inRect)
    {
        Listing_Standard ls =  new Listing_Standard();
        ls.Begin(inRect);
        ls.CheckboxLabeled((string) "ME_addNegatives".Translate(), ref MechadendritesExpanded_Settings.flagNegatives);
        ls.End();
    }

    public class MechadendritesExpanded_Mod : Mod
    {
        public MechadendritesExpanded_Mod(ModContentPack content)
            : base(content)
        {
            this.GetSettings<MechadendritesExpanded_Settings>();
        }
    }
    
    public override string SettingsCategory() => "MechadendritesExpanded";
    
    public override void DoSettingsWindowContents(Rect inRect)
    {
        MechadendritesExpanded_Settings.DoWindowsContents(inRect);
    }
}
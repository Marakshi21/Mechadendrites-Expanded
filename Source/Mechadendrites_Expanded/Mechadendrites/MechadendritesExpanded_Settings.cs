using System.Collections.Generic;
using Verse;
using UnityEngine;
using MechadendritesExpanded;

namespace MechadendritesExpanded
{
    public class MechadendritesExpandedSettings : ModSettings
    {
        public bool exampleBool;
        public float exampleFloat;
        public List<Pawn> exampleListOfPawns = new List<Pawn>();

        public override void ExposeData()
        {
            Scribe_Values.Look(ref exampleBool, "exampleBool");
            Scribe_Values.Look(ref exampleFloat, "exampleFloat", 200f);
            Scribe_Collections.Look(ref exampleListOfPawns, "exampleListOfPawns", LookMode.Reference);
            base.ExposeData();
        }
    }

    public class MechadendritesExpandedMod : Mod
    {
        MechadendritesExpandedSettings settings;

        public MechadendritesExpandedMod(ModContentPack Content) : base(Content)
        {
            this.settings = GetSettings<MechadendritesExpandedSettings>();
        }

public override void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listingStandard = new Listing_Standard();
            listingStandard.Begin(inRect);
            listingStandard.CheckboxLabeled("exampleBoolExplanation", ref settings.exampleBool, "exampleBoolToolTip");
            listingStandard.Label("exampleFloatExplanation");
            settings.exampleFloat = listingStandard.Slider(settings.exampleFloat, 100f, 300f);
            base.DoSettingsWindowContents(inRect);
        }

        public override string SettingsCategory()
        {
            return "Mechadendrites Expanded".Translate();
        }
    }
}


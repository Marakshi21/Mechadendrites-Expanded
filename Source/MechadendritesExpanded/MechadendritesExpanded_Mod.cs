using UnityEngine;
using Verse;

namespace MechadendritesExpanded
{
    // Instantiate mod settings
    public class MechadendritesExpanded_Mod : Mod
    {
        public MechadendritesExpanded_Mod(ModContentPack content)
            : base(content)
        {
            this.GetSettings<MechadendritesExpanded_Settings>();
        }

        public override string SettingsCategory() => "Mechadendrites Expanded";

        public override void DoSettingsWindowContents(Rect inRect)
        {
            MechadendritesExpanded_Settings.DoSettingsWindowContents(inRect);
        }
    }
}
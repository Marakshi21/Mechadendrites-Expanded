using UnityEngine;
using Verse;

namespace MechadendritesExpanded
{
    public class MechadendritesExpandedMod : Mod
    {
        public MechadendritesExpandedMod(ModContentPack content)
            : base(content)
        {
            this.GetSettings<MechadendritesExpandedSettings>();
        }

        public override string SettingsCategory() => "Mechadendrites Expanded";

        public override void DoSettingsWindowContents(Rect inRect)
        {
            MechadendritesExpandedSettings.DoSettingsWindowContents(inRect);
        }
    }
}
using UnityEngine;
using Verse;
// Resharper disable all

#nullable disable
namespace MechadendritesExpanded;

public class MechadendritesExpanded_Mod : Mod
{
    public MechadendritesExpanded_Mod(ModContentPack content)
        : base(content)
    {
        this.GetSettings<MechadendritesExpanded_Settings>();
    }
    
    public override string SettingsCategory() => "Dusk.MechadendritesExpanded".Translate();

    public override void DoSettingsWindowContents(Rect inRect)
    {
        MechadendritesExpanded_Settings.DoSettingsWindowContents(inRect);
    }
}
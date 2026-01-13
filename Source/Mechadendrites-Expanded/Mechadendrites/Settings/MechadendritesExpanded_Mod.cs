using UnityEngine;
using Verse;
// Resharper disable all

#nullable disable
namespace Mechadendrites.Settings;

public class MechadendritesExpanded_Mod : Mod
{
    public MechadendritesExpanded_Mod(ModContentPack content)
        : base(content)
    {
        this.GetSettings<MechadendritesExpanded_Settings>();
    }
    
    public override string SettingsCategory() => "Dusk.Mechadendrites".Translate();

    public override void DoSettingsWindowContents(Rect inRect)
    {
        MechadendritesExpanded_Settings.DoSettingsWindowContents(inRect);
    }
}
using RimWorld;
using Verse;
// ReSharper disable All

#nullable disable
namespace MechadendritesExpanded;

[DefOf]
public static class MechadendritesExpanded_BodyPartDefOf
{
    public static BodyPartDef Dusk_Mechadendrites;
    
    static MechadendritesExpanded_BodyPartDefOf() => DefOfHelper.EnsureInitializedInCtor(typeof (BodyPartDefOf));
}
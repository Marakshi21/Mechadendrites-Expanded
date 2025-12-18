using System.Reflection;
using HarmonyLib;
using Verse;
namespace MechadendritesExpanded
{
    public class MechadendritesExpanded : Mod
    {
        public MechadendritesExpanded(ModContentPack content) : base(content)
        { 
            new Harmony("com.mechadendritesexpanded").PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
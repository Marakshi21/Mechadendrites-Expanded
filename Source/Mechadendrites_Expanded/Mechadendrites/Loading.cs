using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;

namespace Marak.Mechadendrites.Bootstrap
{
    [StaticConstructorOnStartup]
    public static class MechadendritesExpandedLoader
    {
        static MechadendritesExpandedLoader()
        {
            Log.Message("[Mechadendrites Expanded] Loaded");
        }
    }
}

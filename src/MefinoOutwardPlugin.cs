using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;

namespace Mefino.Plugin
{
    [BepInPlugin(GUID, NAME, VERSION)]
    public class MefinoOutwardPlugin : BaseUnityPlugin
    {
        public const string GUID = "io.mefino.outwardplugin";
        public const string NAME = "Mefino Outward Plugin";
        public const string VERSION = "0.1.0.0";
    }
}

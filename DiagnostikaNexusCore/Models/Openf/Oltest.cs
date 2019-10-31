using System;
using System.Collections.Generic;

namespace DiagnostikaNexusCore.Models.Openf
{
    public partial class Oltest
    {
        public short OltestNum { get; set; }
        public int OltestParam { get; set; }
        public string OltestMuestra { get; set; }
        public string OltestUnidades { get; set; }
        public float? OltestFactor { get; set; }
        public string OltestToOl { get; set; }
        public string OltestFromOl { get; set; }
        public string OltestValueMenor { get; set; }
        public string OltestValueMayor { get; set; }

        public virtual Olnum OltestNumNavigation { get; set; }
        public virtual Otest OltestParamNavigation { get; set; }
    }
}

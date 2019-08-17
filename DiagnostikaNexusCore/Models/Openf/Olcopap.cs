using System;
using System.Collections.Generic;

namespace DiagnostikaNexusCore.Models.Openf
{
    public partial class Olcopap
    {
        public short OlcopapNum { get; set; }
        public short OlcopapSector { get; set; }
        public short OlcopapCopa { get; set; }
        public int OlcopapParam { get; set; }
        public string OlcopapMuestra { get; set; }
        public string OlcopapName { get; set; }
    }
}

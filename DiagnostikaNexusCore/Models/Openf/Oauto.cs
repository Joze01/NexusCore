using System;
using System.Collections.Generic;

namespace DiagnostikaNexusCore.Models.Openf
{
    public partial class Oauto
    {
        public DateTime AutoDate { get; set; }
        public DateTime? AutoDateProg { get; set; }
        public DateTime? AutoTime { get; set; }
        public int AutoOrder { get; set; }
        public short AutoNum { get; set; }
        public short? AutoSector { get; set; }
        public short? AutoCopa { get; set; }
        public short? AutoOrigen { get; set; }
        public string AutoId { get; set; }
        public string AutoSampletype { get; set; }
        public string AutoTesttype { get; set; }
    }
}

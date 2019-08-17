using System;
using System.Collections.Generic;

namespace DiagnostikaNexusCore.Models.Openf
{
    public partial class OtP
    {
        public DateTime TPDate { get; set; }
        public int TPParam { get; set; }
        public int TPOrder { get; set; }
        public short TPCount { get; set; }
        public short? TPFlag1 { get; set; }
        public string TPResultado { get; set; }
        public short? TPCerrado { get; set; }
        public DateTime? TPFecha { get; set; }
        public DateTime? TPHora { get; set; }
    }
}

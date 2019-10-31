using System;
using System.Collections.Generic;

namespace DiagnostikaNexusCore.Models.Openf
{
    public partial class Ocompuesto
    {
        public DateTime CompuestoFecha { get; set; }
        public int CompuestoOrden { get; set; }
        public int CompuestoParam { get; set; }
        public short CompuestoOrden1 { get; set; }
        public short CompuestoOrden2 { get; set; }
        public string CompuestoTexto16 { get; set; }
        public string CompuestoTexto48 { get; set; }
        public string CompuestoTexto64 { get; set; }
        public float? CompuestoNum1 { get; set; }
        public float? CompuestoNum2 { get; set; }
        public float? CompuestoNum3 { get; set; }
        public float? CompuestoNum4 { get; set; }
    }
}

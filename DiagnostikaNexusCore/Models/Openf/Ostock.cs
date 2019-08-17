using System;
using System.Collections.Generic;

namespace DiagnostikaNexusCore.Models.Openf
{
    public partial class Ostock
    {
        public int StockCodigo { get; set; }
        public DateTime? StockFecha { get; set; }
        public DateTime? Fuc { get; set; }
        public float? Cpp { get; set; }
        public float? Cmp { get; set; }
        public float? Puc { get; set; }
        public int? Npr { get; set; }
        public int? Total { get; set; }
        public short? Stockactual { get; set; }
        public short? Nuc { get; set; }
        public short? Minalerta { get; set; }
    }
}

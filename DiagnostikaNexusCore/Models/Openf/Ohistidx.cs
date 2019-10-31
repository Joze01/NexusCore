using System;
using System.Collections.Generic;

namespace DiagnostikaNexusCore.Models.Openf
{
    public partial class Ohistidx
    {
        public int IdxUnicoId { get; set; }
        public DateTime? IdxFichaDate { get; set; }
        public DateTime? IdxFechaNacimiento { get; set; }
        public int? IdxLong1 { get; set; }
        public short IdxCount { get; set; }
        public short? IdxHistoCount { get; set; }
        public short? IdxInt1 { get; set; }
        public short? IdxInt2 { get; set; }
        public string IdxHistoria { get; set; }
        public string IdxDni { get; set; }
        public string IdxApell1 { get; set; }
        public string IdxApell2 { get; set; }
        public string IdxName { get; set; }
        public string Tfono { get; set; }
        public string Direccion { get; set; }
        public string Poblacion { get; set; }
        public string IdxSexo { get; set; }
        public string IdxChar1 { get; set; }
        public string Orden { get; set; }
    }
}

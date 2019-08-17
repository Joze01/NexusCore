using System;
using System.Collections.Generic;

namespace DiagnostikaNexusCore.Models.Openf
{
    public partial class Incidencias
    {
        public decimal IncidenciaUid { get; set; }
        public int? InciUnicoId { get; set; }
        public DateTime? InciDate { get; set; }
        public int? InciOrder { get; set; }
        public int? InciParam { get; set; }
        public short? InciTipo { get; set; }
    }
}

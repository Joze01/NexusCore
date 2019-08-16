using System;
using System.Collections.Generic;

namespace TestProject.Models.Openf
{
    public partial class OtHisto
    {
        public DateTime THistoDate { get; set; }
        public DateTime? THistoFechaMod { get; set; }
        public DateTime? THistoFechaVal { get; set; }
        public int THistoParam { get; set; }
        public DateTime? THistoTimeMod { get; set; }
        public DateTime? THistoTimeVal { get; set; }
        public int THistoOrder { get; set; }
        public short THistoCount { get; set; }
        public short? THistoValidado { get; set; }
        public string THistoModificadoPor { get; set; }
        public string THistoValidadoPor { get; set; }
        public string THistoRlinea { get; set; }
    }
}

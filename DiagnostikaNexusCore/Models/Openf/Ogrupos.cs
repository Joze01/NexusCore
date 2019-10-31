using System;
using System.Collections.Generic;

namespace DiagnostikaNexusCore.Models.Openf
{
    public partial class Ogrupos
    {
        public Ogrupos()
        {
            OformuData = new HashSet<OformuData>();
            OperfilData = new HashSet<OperfilData>();
            Otest = new HashSet<Otest>();
        }

        public int Clase { get; set; }
        public float? ClaseValor { get; set; }
        public string ClaseName { get; set; }
        public string ClaseDescripcion { get; set; }

        public virtual ICollection<OformuData> OformuData { get; set; }
        public virtual ICollection<OperfilData> OperfilData { get; set; }
        public virtual ICollection<Otest> Otest { get; set; }
    }
}

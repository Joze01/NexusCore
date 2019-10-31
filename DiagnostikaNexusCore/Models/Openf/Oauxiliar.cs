using System;
using System.Collections.Generic;

namespace DiagnostikaNexusCore.Models.Openf
{
    public partial class Oauxiliar
    {
        public int Clase { get; set; }
        public float? ClaseValor { get; set; }
        public string ClaseName { get; set; }
        public string ClaseDescripcion { get; set; }
        public string ClaseExtra1 { get; set; }
        public string ClaseExtra2 { get; set; }
    }
}

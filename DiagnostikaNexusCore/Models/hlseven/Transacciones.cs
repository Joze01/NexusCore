using System;
using System.Collections.Generic;

namespace DiagnostikaNexusCore.Models.hlseven
{
    public partial class Transacciones
    {
        public int Indice { get; set; }
        public string Peticion { get; set; }
        public string Respuesta { get; set; }
        public int Estado { get; set; }
        public DateTime Fecha { get; set; }
        public int? Pruebas { get; set; }
        public int? Completas { get; set; }
        public string Siapsid { get; set; }
        public int? Orc { get; set; }
        public string Ox { get; set; }

        public virtual EstadosTransacciones EstadoNavigation { get; set; }
    }
}

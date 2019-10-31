using System;
using System.Collections.Generic;

namespace TestProject.Models.Openf
{
    public partial class Oprecio
    {
        public int PrecioCodigo { get; set; }
        public int CiaClase { get; set; }
        public string CiaName { get; set; }
        public string CodigoCia { get; set; }
        public float? PrecioValor { get; set; }

        public virtual Otest PrecioCodigoNavigation { get; set; }
    }
}

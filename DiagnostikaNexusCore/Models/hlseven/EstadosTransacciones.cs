using System;
using System.Collections.Generic;

namespace DiagnostikaNexusCore.Models.hlseven
{
    public partial class EstadosTransacciones
    {
        public EstadosTransacciones()
        {
            Transacciones = new HashSet<Transacciones>();
        }

        public int Idestado { get; set; }
        public string Nombreestado { get; set; }

        public virtual ICollection<Transacciones> Transacciones { get; set; }
    }
}

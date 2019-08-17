using System;
using System.Collections.Generic;

namespace DiagnostikaNexusCore.Models.Openf
{
    public partial class SiapsEdad
    {
        public SiapsEdad()
        {
            SiapsSubelemento = new HashSet<SiapsSubelemento>();
        }

        public decimal Indice { get; set; }
        public string NombreEdad { get; set; }
        public decimal? DiasMax { get; set; }
        public decimal? DiasMin { get; set; }

        public virtual ICollection<SiapsSubelemento> SiapsSubelemento { get; set; }
    }
}

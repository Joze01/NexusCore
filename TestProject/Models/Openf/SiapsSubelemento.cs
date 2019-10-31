using System;
using System.Collections.Generic;

namespace TestProject.Models.Openf
{
    public partial class SiapsSubelemento
    {
        public decimal Indice { get; set; }
        public string IdElemento { get; set; }
        public string IdSubelemento { get; set; }
        public string ParCodigo { get; set; }
        public string SubelementoNombre { get; set; }
        public decimal GeneroId { get; set; }
        public decimal? EdadId { get; set; }

        public virtual SiapsEdad Edad { get; set; }
    }
}

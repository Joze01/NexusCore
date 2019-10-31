using System;
using System.Collections.Generic;

namespace TestProject.Models.Openf
{
    public partial class Oproceso
    {
        public Oproceso()
        {
            OprocesoOt = new HashSet<OprocesoOt>();
        }

        public int ProcesoCode { get; set; }
        public string ProcesoNombre { get; set; }
        public string ProcesoDescripcion { get; set; }
        public int? ProcesoDuracion { get; set; }
        public string ProcesoIcono { get; set; }
        public string ProcesoPrefijo { get; set; }

        public virtual ICollection<OprocesoOt> OprocesoOt { get; set; }
    }
}

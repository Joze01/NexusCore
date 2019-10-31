using System;
using System.Collections.Generic;

namespace TestProject.Models.Openf
{
    public partial class OprocesoOt
    {
        public DateTime ProcesoOtFecha { get; set; }
        public int ProcesoOtOrden { get; set; }
        public int ProcesoOtParam { get; set; }
        public string ProcesoOtId { get; set; }
        public int ProcesoOtCodigo { get; set; }
        public DateTime? ProcesoOtFechaI { get; set; }
        public DateTime? ProcesoOtFechaF { get; set; }
        public DateTime? ProcesoOtHoraI { get; set; }
        public DateTime? ProcesoOtHoraF { get; set; }
        public string ProcesoOtComentario { get; set; }
        public short? ProcesoOtFlag { get; set; }
        public short? ProcesoOtNew { get; set; }
        public short ProcesoOtRow { get; set; }
        public short ProcesoOtCol { get; set; }

        public virtual Oproceso ProcesoOtCodigoNavigation { get; set; }
    }
}

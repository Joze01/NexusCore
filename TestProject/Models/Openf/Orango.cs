using System;
using System.Collections.Generic;

namespace TestProject.Models.Openf
{
    public partial class Orango
    {
        public int RangoCodigo { get; set; }
        public short RangoTipo { get; set; }
        public short? RangoEdadInf { get; set; }
        public short? RangoEdadSup { get; set; }
        public short? TipoEdad { get; set; }
        public string RangoSexo { get; set; }
        public float? RangoInf { get; set; }
        public float? RangoSup { get; set; }

        public virtual Otest RangoCodigoNavigation { get; set; }
    }
}

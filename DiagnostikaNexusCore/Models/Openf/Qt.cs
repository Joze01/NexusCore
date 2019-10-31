using System;
using System.Collections.Generic;

namespace DiagnostikaNexusCore.Models.Openf
{
    public partial class Qt
    {
        public int QtOrden { get; set; }
        public DateTime? QtDate { get; set; }
        public DateTime? QtTime { get; set; }
        public short QtOlnum { get; set; }
        public int QtParam { get; set; }
        public string QtControl { get; set; }
        public float QtResultado { get; set; }
        public short? QtStatus { get; set; }
        public short? QtFlag { get; set; }

        public virtual Olnum QtOlnumNavigation { get; set; }
        public virtual Otest QtParamNavigation { get; set; }
    }
}

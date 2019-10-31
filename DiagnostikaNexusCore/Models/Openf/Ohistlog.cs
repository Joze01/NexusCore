using System;
using System.Collections.Generic;

namespace DiagnostikaNexusCore.Models.Openf
{
    public partial class Ohistlog
    {
        public int LogUnicoId { get; set; }
        public DateTime LogDate { get; set; }
        public DateTime LogDateCopy { get; set; }
        public int LogOrder { get; set; }
        public short LogOrderCopy { get; set; }
        public short? LogVolumen { get; set; }
        public string LogVolumenDescrip { get; set; }
    }
}

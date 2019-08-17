using System;
using System.Collections.Generic;

namespace DiagnostikaNexusCore.Models.Openf
{
    public partial class Cola
    {
        public short ColaToOnline { get; set; }
        public short ColaFromOnline { get; set; }
        public short ColaTipo { get; set; }
        public int ColaNum { get; set; }
        public DateTime? ColaDate { get; set; }
        public DateTime? ColaTime { get; set; }
        public short? ColaCount { get; set; }
        public short? ColaFlag { get; set; }
        public string ColaDescrip1 { get; set; }
        public string ColaDescrip2 { get; set; }
        public string ColaDescrip3 { get; set; }
        public string ColaDescrip4 { get; set; }
    }
}

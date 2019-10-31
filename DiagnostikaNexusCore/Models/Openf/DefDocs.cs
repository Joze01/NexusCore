using System;
using System.Collections.Generic;

namespace DiagnostikaNexusCore.Models.Openf
{
    public partial class DefDocs
    {
        public decimal DefDocUid { get; set; }
        public int? DefDocTestUid { get; set; }
        public int? DefDocServicio { get; set; }
        public short? DefDocTipo { get; set; }
        public string DefDocDescrip { get; set; }
        public short? PublicDefDoc { get; set; }
        public short? ConfiDefDoc { get; set; }
        public short? ComparDefDoc { get; set; }
        public string DefDocWrite { get; set; }
        public short? DefDocWriteOver { get; set; }
        public short? DefDocWriteImp { get; set; }
        public short? DefDocWriteRtf { get; set; }
        public string DefDocVts { get; set; }
        public string DefDocGrafico { get; set; }
        public short? DefDocPrpt { get; set; }
        public short? DefDocPvts { get; set; }
        public short? DefDocPvw { get; set; }
        public string DefDocPfile { get; set; }
    }
}

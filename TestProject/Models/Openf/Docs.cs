using System;
using System.Collections.Generic;

namespace TestProject.Models.Openf
{
    public partial class Docs
    {
        public int DocInciUid { get; set; }
        public int DocNum { get; set; }
        public DateTime? FechaDoc { get; set; }
        public int? DocDiagUid { get; set; }
        public int? DocTtoUid { get; set; }
        public int? DocRiesgoUid { get; set; }
        public string DocUser { get; set; }
        public int? DocDefDoc { get; set; }
        public int? DocServiDoc { get; set; }
        public short? TipoDoc { get; set; }
        public string TitleDoc { get; set; }
        public short? PublicDoc { get; set; }
        public short? ConfiDoc { get; set; }
        public short? ComparDoc { get; set; }
        public short? PrivateDoc { get; set; }
        public string DocGrafico { get; set; }
        public short? DocPvts { get; set; }
        public short? DocPvw { get; set; }
        public string OleExt { get; set; }
        public string TextoDoc { get; set; }
        public string VtsDoc { get; set; }
        public string ImgDoc { get; set; }
        public string OleDoc { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace TestProject.Models.Openf
{
    public partial class Prodef
    {
        public int ProdefNum { get; set; }
        public short? ProdefTipo { get; set; }
        public short? ProdefGrafico { get; set; }
        public short? Prodef3d { get; set; }
        public string ProdefLinkrange { get; set; }
        public short? ProdefGrafLeft { get; set; }
        public short? ProdefGrafTop { get; set; }
        public short? ProdefGrafWidth { get; set; }
        public short? ProdefGrafHeigh { get; set; }
        public short? ProdefPages { get; set; }
        public string ProdefDescrip { get; set; }
        public string ProdefFile { get; set; }
    }
}

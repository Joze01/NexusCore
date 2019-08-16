using System;
using System.Collections.Generic;

namespace TestProject.Models.Openf
{
    public partial class Owg
    {
        public short OwgNum { get; set; }
        public DateTime OwgDate { get; set; }
        public int OwgOrder { get; set; }
        public short? OwgFlag { get; set; }
        public DateTime? OwgTime { get; set; }
        public string OwgComentario { get; set; }
    }
}

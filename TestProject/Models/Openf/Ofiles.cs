using System;
using System.Collections.Generic;

namespace TestProject.Models.Openf
{
    public partial class Ofiles
    {
        public short OfilesClase { get; set; }
        public string OfilesFname { get; set; }
        public string OfilesFcode { get; set; }
        public string OfilesDescrip { get; set; }
        public DateTime? OfilesDate { get; set; }
        public DateTime? OfilesTime { get; set; }
        public string OfilesUser { get; set; }
    }
}

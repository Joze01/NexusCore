using System;
using System.Collections.Generic;

namespace TestProject.Models.Openf
{
    public partial class Ogol
    {
        public short OgolNum { get; set; }
        public DateTime OgolDate { get; set; }
        public int OgolOrder { get; set; }
        public short? OgolFlag { get; set; }
        public DateTime? OgolTime { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DiagnostikaNexusCore.Models.Openf
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

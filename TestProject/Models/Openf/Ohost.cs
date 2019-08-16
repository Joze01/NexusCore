using System;
using System.Collections.Generic;

namespace TestProject.Models.Openf
{
    public partial class Ohost
    {
        public DateTime HostDate { get; set; }
        public int? Accesion { get; set; }
        public int HostOrder { get; set; }
        public short? HostSector { get; set; }
        public short? HostCopa { get; set; }
        public short? HostFlag { get; set; }
        public string PatientId { get; set; }
        public string HostTesttype { get; set; }
        public string Hostsampletype { get; set; }
        public string Hostprinttype { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace TestProject.Models.Openf
{
    public partial class Ospecimen
    {
        public int SpecimenNum { get; set; }
        public int SpecimenUnicoId { get; set; }
        public string SpecimenMuestra { get; set; }
        public DateTime? SpecimenFecha { get; set; }
        public string SpecimenDevice { get; set; }
        public string SpecimenXy { get; set; }
        public string SpecimenLabel { get; set; }
    }
}

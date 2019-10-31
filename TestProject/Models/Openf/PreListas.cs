using System;
using System.Collections.Generic;

namespace TestProject.Models.Openf
{
    public partial class PreListas
    {
        public PreListas()
        {
            PreData = new HashSet<PreData>();
        }

        public string PreCode { get; set; }
        public string PreDescrip { get; set; }

        public virtual ICollection<PreData> PreData { get; set; }
    }
}

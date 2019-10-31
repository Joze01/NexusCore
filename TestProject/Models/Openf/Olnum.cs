using System;
using System.Collections.Generic;

namespace TestProject.Models.Openf
{
    public partial class Olnum
    {
        public Olnum()
        {
            Oltest = new HashSet<Oltest>();
            Qt = new HashSet<Qt>();
        }

        public short OlnumNum { get; set; }
        public short? OlnumGrupo { get; set; }
        public string OlnumDescrip { get; set; }
        public short? OlnumSectores { get; set; }
        public short? OlnumCopas { get; set; }
        public short? OlnumBarcode { get; set; }
        public short? OlnumBarcodePrefix { get; set; }
        public short? OlnumRealtime { get; set; }
        public short? OlnumBidireccional { get; set; }
        public short? OlnumTrans { get; set; }

        public virtual Olgrupos OlnumGrupoNavigation { get; set; }
        public virtual ICollection<Oltest> Oltest { get; set; }
        public virtual ICollection<Qt> Qt { get; set; }
    }
}

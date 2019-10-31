using System;
using System.Collections.Generic;

namespace DiagnostikaNexusCore.Models.Openf
{
    public partial class Olgrupos
    {
        public Olgrupos()
        {
            OformuData = new HashSet<OformuData>();
            Olnum = new HashSet<Olnum>();
            OperfilData = new HashSet<OperfilData>();
            Otest = new HashSet<Otest>();
        }

        public short OlgruposNum { get; set; }
        public string OlgruposDescrip { get; set; }

        public virtual ICollection<OformuData> OformuData { get; set; }
        public virtual ICollection<Olnum> Olnum { get; set; }
        public virtual ICollection<OperfilData> OperfilData { get; set; }
        public virtual ICollection<Otest> Otest { get; set; }
    }
}

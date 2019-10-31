using System;
using System.Collections.Generic;

namespace TestProject.Models.Openf
{
    public partial class Olcopa
    {
        public short OlcopaNum { get; set; }
        public short OlcopaSector { get; set; }
        public short OlcopaCopa { get; set; }
        public short? OlcopaTipo { get; set; }
        public DateTime OlcopaDate { get; set; }
        public int OlcopaOrder { get; set; }
        public int OlcopaCustom { get; set; }
        public string OlcopaMuestra { get; set; }
        public string OlcopaDescrip { get; set; }
        public short? OlcopaNmuestra { get; set; }
        public short? OlcopaOrigen { get; set; }
        public short? OlcopaStatus { get; set; }
        public short? OlcopaError { get; set; }
    }
}

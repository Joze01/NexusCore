using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagnostikaNexusCore.Models.PublicRequest
{
    public class Checkin
    {
        public string token { set; get; }
        public string mensaje { set; get; }
        public Boolean estado { set; get; }
    }
}

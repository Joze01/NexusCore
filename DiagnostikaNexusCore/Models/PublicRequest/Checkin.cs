using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagnostikaNexusCore.Models.PublicRequest
{
    public class Checkin
    {
        public string Token { set; get; }
        public string mensaje { set; get; }
        public string estado { set; get; }
    }
}

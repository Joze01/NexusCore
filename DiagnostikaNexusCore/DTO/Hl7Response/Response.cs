using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagnostikaNexusCore.DOT.Hl7Response
{
    public class Response
    {
        private MSHHeader mshHeader;
        private ORCHeader orcHeader;
        private List<OBR> obrList;

        public MSHHeader MshHeader { get => mshHeader; set => mshHeader = value; }
        public ORCHeader OrcHeader { get => orcHeader; set => orcHeader = value; }
        public List<OBR> ObrList { get => obrList; set => obrList = value; }
    }
}

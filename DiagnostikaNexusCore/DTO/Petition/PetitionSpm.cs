using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagnostikaNexusCore.DOT.Petition
{
    public class PetitionSPM
    {
        private string spm1_id;
        private string spm2_specimenId;
        private string spm4_1_identifier;
        private string spm4_2_text;
        private string spm17_specimenCollectinDate;

        public string Spm1_id { get => spm1_id; set => spm1_id = value; }
        public string Spm2_specimenId { get => spm2_specimenId; set => spm2_specimenId = value; }
        public string Spm4_1_identifier { get => spm4_1_identifier; set => spm4_1_identifier = value; }
        public string Spm4_2_text { get => spm4_2_text; set => spm4_2_text = value; }
        public string Spm17_specimenCollectinDate { get => spm17_specimenCollectinDate; set => spm17_specimenCollectinDate = value; }
    }
}

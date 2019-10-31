using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagnostikaNexusCore.DOT.Hl7Response
{
    public class OBXBody
    {
        private string obx_1_ObxId;
        private string obx_2_ValueType;
        private string obx_3_1_Identifier;
        private string obx_3_2_text;
        private string obx_4_observationSubid;
        private string obx_5_ObservationValue;
        private string obx_6_units;
        private string obx_7_rangeReference;
        private string obx_11_ObservationResultStatus;
        private string obx_14_dateofObservation;

        public string Obx_1_ObxId { get => obx_1_ObxId; set => obx_1_ObxId = value; }
        public string Obx_2_ValueType { get => obx_2_ValueType; set => obx_2_ValueType = value; }
        public string Obx_3_1_Identifier { get => obx_3_1_Identifier; set => obx_3_1_Identifier = value; }
        public string Obx_3_2_text { get => obx_3_2_text; set => obx_3_2_text = value; }
        public string Obx_4_observationSubid { get => obx_4_observationSubid; set => obx_4_observationSubid = value; }
        public string Obx_5_ObservationValue { get => obx_5_ObservationValue; set => obx_5_ObservationValue = value; }
        public string Obx_6_units { get => obx_6_units; set => obx_6_units = value; }
        public string Obx_7_rangeReference { get => obx_7_rangeReference; set => obx_7_rangeReference = value; }
        public string Obx_11_ObservationResultStatus { get => obx_11_ObservationResultStatus; set => obx_11_ObservationResultStatus = value; }
        public string Obx_14_dateofObservation { get => obx_14_dateofObservation; set => obx_14_dateofObservation = value; }
    }
}

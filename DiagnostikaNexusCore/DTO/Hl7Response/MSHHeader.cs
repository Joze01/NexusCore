using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagnostikaNexusCore.DOT.Hl7Response
{
    public class MSHHeader
    {
        private string msh_1_fielSeparador;
        private string msh_2_EncodeingCaracters;
        private string msh_3_sendingApplication;
        private string msh_4_1_namespaceId;
        private string msh_4_2_UniversalID;
        private string msh_5_ReceivingApplication; //SIAPS
        private string msh_6_ReceivingFacility;
        private string msh_7_DateTimeOfMessage;
        private string msh_9_1_MessageCode; //OUL
        private string msh_9_2_TriggerEvent; //R22
        private string msh_10_MessageControlId;
        private string msh_11_ProcessingID;
        private string msh_12_VersionId;
        private string msh_15_acceptAcknowledgemeType;//AL
        private string msh_16_ApplicationAcknowledgmeType;//AL

        public string Msh_1_fielSeparador { get => msh_1_fielSeparador; set => msh_1_fielSeparador = value; }
        public string Msh_2_EncodeingCaracters { get => msh_2_EncodeingCaracters; set => msh_2_EncodeingCaracters = value; }
        public string Msh_3_sendingApplication { get => msh_3_sendingApplication; set => msh_3_sendingApplication = value; }
        public string Msh_4_1_namespaceId { get => msh_4_1_namespaceId; set => msh_4_1_namespaceId = value; }
        public string Msh_4_2_UniversalID { get => msh_4_2_UniversalID; set => msh_4_2_UniversalID = value; }
        public string Msh_5_ReceivingApplication { get => msh_5_ReceivingApplication; set => msh_5_ReceivingApplication = value; }
        public string Msh_6_ReceivingFacility { get => msh_6_ReceivingFacility; set => msh_6_ReceivingFacility = value; }
        public string Msh_7_DateTimeOfMessage { get => msh_7_DateTimeOfMessage; set => msh_7_DateTimeOfMessage = value; }
        public string Msh_9_1_MessageCode { get => msh_9_1_MessageCode; set => msh_9_1_MessageCode = value; }
        public string Msh_9_2_TriggerEvent { get => msh_9_2_TriggerEvent; set => msh_9_2_TriggerEvent = value; }
        public string Msh_10_MessageControlId { get => msh_10_MessageControlId; set => msh_10_MessageControlId = value; }
        public string Msh_11_ProcessingID { get => msh_11_ProcessingID; set => msh_11_ProcessingID = value; }
        public string Msh_12_VersionId { get => msh_12_VersionId; set => msh_12_VersionId = value; }
        public string Msh_15_acceptAcknowledgemeType { get => msh_15_acceptAcknowledgemeType; set => msh_15_acceptAcknowledgemeType = value; }
        public string Msh_16_ApplicationAcknowledgmeType { get => msh_16_ApplicationAcknowledgmeType; set => msh_16_ApplicationAcknowledgmeType = value; }
    }
}

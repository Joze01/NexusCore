using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiagnostikaNexusCore.DOT;
using DiagnostikaNexusCore.DOT.Hl7Response;
using DiagnostikaNexusCore.BLL.Util;
using DiagnostikaNexusCore.Models.hlseven;

namespace DiagnostikaNexusCore.BLL.Hl7ResponseBuilder
{
    public class ResponseBuilder
    {

        private readonly hl7Context _contexthl7;

        
        public async Task<Response> BuildResponseAsync(string controllId, string orderID)
        {
            Response response = new Response();
            response.MshHeader = BuildMSHHeader(orderID, controllId);
            response.OrcHeader = await BuildOrcHeader(orderID);
            return response;
        }

        private MSHHeader BuildMSHHeader(string orderId, string areaControllId)
        {
            MSHHeader mSHHeader = new MSHHeader();
            mSHHeader.Msh_1_fielSeparador = CoreConfiguration.FieldSeparator;
            mSHHeader.Msh_2_EncodeingCaracters = CoreConfiguration.EncodeingCaracters;
            mSHHeader.Msh_3_sendingApplication = CoreConfiguration.ApplicationName;
            mSHHeader.Msh_4_1_namespaceId = CoreConfiguration.NameSpaceId;
            mSHHeader.Msh_4_2_UniversalID = CoreConfiguration.UniversalIDd;
            mSHHeader.Msh_5_ReceivingApplication = CoreConfiguration.ReceivingApplication;
            mSHHeader.Msh_6_ReceivingFacility = CoreConfiguration.ReceivingFacility;
            mSHHeader.Msh_7_DateTimeOfMessage = DateTime.Now.ToString(CoreConfiguration.DateFormatString);
            mSHHeader.Msh_9_1_MessageCode = CoreConfiguration.MessageCode;
            mSHHeader.Msh_9_2_TriggerEvent = CoreConfiguration.TriggerEvent;
            mSHHeader.Msh_10_MessageControlId = areaControllId;
            mSHHeader.Msh_11_ProcessingID = CoreConfiguration.ProcessingID;
            mSHHeader.Msh_12_VersionId = CoreConfiguration.VersionId;
            mSHHeader.Msh_15_acceptAcknowledgemeType = CoreConfiguration.AcceptAcknowledgemeType;
            mSHHeader.Msh_16_ApplicationAcknowledgmeType = CoreConfiguration.ApplicationAcknowledgmeType;
            return mSHHeader;
        }

        private async Task<ORCHeader> BuildOrcHeader(string orderId) {
            ORCHeader orcHeader = new ORCHeader();
            
            return orcHeader;
        }
    }
}

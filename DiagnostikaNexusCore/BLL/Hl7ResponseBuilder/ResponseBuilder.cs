using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiagnostikaNexusCore.DOT;
using DiagnostikaNexusCore.DOT.Hl7Response;
using DiagnostikaNexusCore.BLL.Util;

namespace DiagnostikaNexusCore.BLL.Hl7ResponseBuilder
{
    public class ResponseBuilder
    {
        

        public Response buildResponse() {
            Response response = new Response();


            return response;
        }

        private Response buildHeader() {
            MSHHeader mSHHeader = new MSHHeader();
            mSHHeader.Msh_1_fielSeparador = CoreConfiguration.FieldSeparator;
            mSHHeader.Msh_2_EncodeingCaracters = CoreConfiguration.EncodeingCaracters;
            mSHHeader.Msh_3_sendingApplication = CoreConfiguration.ApplicationName;
           


            return mSHHeader;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MINSAL;

namespace DiagnostikaNexusCore.DAL
{
    public class MINSALCON : MINSAL.interfacelisPortType
    {
        public Task<acceptMessageResponse> acceptMessageAsync(acceptMessageRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<checkinResponse> checkinAsync(checkinRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<checkoutResponse> checkoutAsync(checkoutRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<generarMensajeSolicitudResponse> generarMensajeSolicitudAsync(generarMensajeSolicitudRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

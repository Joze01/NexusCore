using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiagnostikaNexusCore.Models.PublicResponses;
using DiagnostikaNexusCore.Models.Openf;
namespace DiagnostikaNexusCore.BLL.Hl7RequestParser
{
    public class RequestBuilder
    {

        private readonly openfContext _context;

        public RequestBuilder(openfContext context)
        {
            _context = context;
        }

        private List<His2lis> BuildOrderRequest(PeticionEntrante ordersData)
        {
            RequestParser messageParser = new RequestParser();
            RequestBuilderUtil requestBuilderUtil = new RequestBuilderUtil();
            List<His2lis> orderList = new List<His2lis>();


            var requestOrderMessage = ordersData;
            List<String> lastNames = requestBuilderUtil.getLastNames(requestOrderMessage.Pid5_1_familyName);

            foreach (var orderDetail in requestOrderMessage.ListaORB)
            {
                var newOrder = new His2lis();
                newOrder.Orden = requestBuilderUtil.compuseOrderId(requestOrderMessage.Orc4_placerGroupNumer);
                newOrder.Fsolicitud = requestBuilderUtil.currentDateFormated();
                newOrder.Origen = requestOrderMessage.Pv2_patientClass;
                newOrder.Servicio = requestOrderMessage.Orc13_1_pointOfCare;
                newOrder.Doctor = requestOrderMessage.Orc12_1_idNumber;
                newOrder.Libre = "1";
                newOrder.Identificacion = requestOrderMessage.Pid3_1_idNumber;
                newOrder.Nombre = requestOrderMessage.Pid5_2_givenName + " " + requestOrderMessage.Pid5_3_secondName;
                newOrder.Apell1 = lastNames[0];
                newOrder.Apell2 = lastNames[1];
                newOrder.Edad = requestBuilderUtil.getAges(requestOrderMessage.Pid7_datetimeBirth);
                newOrder.Codigo = orderDetail.Obr4_4_AlternateIdentifier;
                newOrder.Sexo = requestBuilderUtil.getGender(requestOrderMessage.Pid8_AdministrativeSex);
                orderList.Add(newOrder);
            }

            return orderList;
        }

        public async Task<AcceptMessage> saveOrder(string jsonMessage)
        {
            AcceptMessage resultMessage = new AcceptMessage();
            RequestParser requestParser = new RequestParser();
            resultMessage.Estado = true;
            resultMessage.Mensaje = "OK";

            List<His2lis> ordersList = BuildOrderRequest(requestParser.decodeOrderData(jsonMessage));
            _context.His2lis.AddRange(ordersList);

            var resultCount = await _context.SaveChangesAsync();

            if (resultCount != ordersList.Count) {
                resultMessage.Estado = false;
                resultMessage.Mensaje = "Error";

            }
            
            return resultMessage;
        }
    }


}

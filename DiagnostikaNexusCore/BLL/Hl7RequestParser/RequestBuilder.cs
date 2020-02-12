using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiagnostikaNexusCore.Models.PublicResponses;
using DiagnostikaNexusCore.Models.hlseven;
using DiagnostikaNexusCore.Models.Openf;
using DiagnostikaNexusCore.BLL.Util;
using Newtonsoft.Json;
using DiagnostikaNexusCore.DOT.Petition;
using DiagnostikaNexusCore.BLL.Security;

namespace DiagnostikaNexusCore.BLL.Hl7RequestParser
{
    public class RequestBuilder
    {

        private readonly OpenfContext _context;
        private readonly hl7Context _hl7Context;

        public RequestBuilder(OpenfContext context,hl7Context hl7Context)
        {
            _hl7Context = hl7Context;
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

        private async Task<Boolean> saveTransaction(PeticionEntrante ordersData, string messageString)
        {
            RequestBuilderUtil utilData = new RequestBuilderUtil();
            Transacciones newTransaction = new Transacciones();
            string orderID = utilData.compuseOrderId(ordersData.Orc4_placerGroupNumer);
            newTransaction.Peticion = messageString;
            newTransaction.Estado = 0;
            newTransaction.Fecha = DateTime.Now;
            newTransaction.Completas = 0;
            newTransaction.Pruebas = ordersData.ListaORB.Count();
            newTransaction.Siapsid = orderID;
            newTransaction.Ox = ordersData.Orc1_orderControl;
            newTransaction.Orc = int.Parse(ordersData.Orc2_placerOrderNumer);

            if (newTransaction.Ox == CoreConfiguration.ModificacionString) {
                    _context.RemoveRange(_context.His2lis.Where(data => data.Orden == orderID));
                    _context.RemoveRange(_context.Ohistidx.Where(data=> data.Orden == orderID));
                    _context.RemoveRange(_context.Oficha.Where(data => data.Custom == decimal.Parse(orderID)));
                    _context.RemoveRange(_context.OtPerfil.Where(data => data.OtPerfilOrder == decimal.Parse(orderID)));
                    _context.RemoveRange(_context.Ot.Where(data => data.TCustom == decimal.Parse(orderID)));
                var deleteCount = _context.SaveChanges();
                var oldTransaction = _hl7Context.Transacciones.Where(data => data.Siapsid == ordersData.Orc4_placerGroupNumer);
                foreach (Transacciones tran in oldTransaction) {
                    tran.Estado = 8;
                }
                _hl7Context.Transacciones.UpdateRange(oldTransaction);
                _hl7Context.SaveChanges();
            }
            _hl7Context.Transacciones.Add(newTransaction);
           var result = await _hl7Context.SaveChangesAsync();
            return result>0;
        }

        public async Task<AcceptMessage> saveOrder(string jsonMessage)
        {
            var jsonObject = JsonConvert.DeserializeObject<PetitionElements>(jsonMessage);
            Autentication autorizaction = new Autentication(_hl7Context);
            AcceptMessage resultMessage = new AcceptMessage();

            if (autorizaction.validateToken(jsonObject.Token))
            {
                RequestParser requestParser = new RequestParser();
                resultMessage.Estado = "true";
                resultMessage.Mensaje = "OK";
                var messageData = requestParser.decodeOrderData(jsonObject);
                var transactionSaved = saveTransaction(messageData, jsonMessage).Result;
                if (transactionSaved)
                {
                    List<His2lis> ordersList = BuildOrderRequest(messageData);
                    foreach (His2lis itemData in ordersList)
                    {
                        _context.His2lis.Add(itemData);
                        _context.SaveChanges();
                    }
                    _context.His2lis.AddRange(ordersList);
                }
                else
                {
                    resultMessage.Estado = "false";
                    resultMessage.Mensaje = "Error";
                }
            }
            else {
                resultMessage.Estado = "false";
                resultMessage.Mensaje = "Token invalido";
            }
            return resultMessage;
        }
    }


}

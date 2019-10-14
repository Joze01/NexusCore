using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiagnostikaNexusCore.DOT.Petition;
using DiagnostikaNexusCore.Models.Openf;
using Newtonsoft.Json;
using NextLevelSeven.Core;

namespace DiagnostikaNexusCore.BLL.Hl7RequestParser
{
    public class RequestParser
    {
        private PeticionEntrante decodeMessageData(string jsonValue)
        {
            string MessageData = jsonValue.Replace("ORC", "\rORC");
            MessageData = MessageData.Replace("OBR", "\rOBR");
            MessageData = MessageData.Replace("PID", "\rPID");
            MessageData = MessageData.Replace("PV1", "\rPV1");
            MessageData = MessageData.Replace("SPM", "\rSPM");

            PeticionEntrante requestOrderMessage = new PeticionEntrante();
            //System.Diagnostics.Debug.WriteLine("PETICION: " + peticion);
            var mensaje = NextLevelSeven.Core.Message.Build(MessageData);
            // first segment in a message (returns IElement)
            var mshSegment = mensaje[1];

            //Llenado de la cabecera MSH
            requestOrderMessage.Msh3_sendingApplication = mshSegment.Field(3).ToString();
            requestOrderMessage.Msh4_sendingFacility = mshSegment.Field(4).ToString();
            requestOrderMessage.Msh5_receivingApplication = mshSegment.Field(5).ToString();
            requestOrderMessage.Msh6_recivingFacilty = mshSegment.Field(6).ToString();
            requestOrderMessage.Msh6_1_idSuministrasnte = mshSegment.Field(6).Component(1).ToString();
            requestOrderMessage.Msh7_dateTimeMessage = mshSegment.Field(7).ToString();
            requestOrderMessage.Msh9_1_messageCode = mshSegment.Field(9).Component(1).ToString();
            requestOrderMessage.Msh9_2_triggerEvent = mshSegment.Field(9).Component(2).ToString();
            requestOrderMessage.Msh10_messageControlID = mshSegment.Field(10).ToString();
            requestOrderMessage.Msh11_processingID = mshSegment.Field(11).ToString();
            requestOrderMessage.Msh12_versionId = mshSegment.Field(12).ToString();
            requestOrderMessage.Msh15_acceptAcknowledgmentType = mshSegment.Field(15).ToString();
            requestOrderMessage.Msh16_applicationAcknowledgmentType = mshSegment.Field(16).ToString();

            //Segmento PID (Paciente ID)
            var pidSegment = mensaje.Segments.OfType("PID").First();
            requestOrderMessage.Pid1_pdi = pidSegment.Field(1).Component(1).ToString();
            requestOrderMessage.Pid3_1_idNumber = pidSegment.Field(3).Component(1).ToString();
            requestOrderMessage.Pid3_4_assigningAutority = pidSegment.Field(3).Component(4).ToString();
            requestOrderMessage.Pid5_1_familyName = pidSegment.Field(5).Component(1).ToString();
            requestOrderMessage.Pid5_2_givenName = pidSegment.Field(5).Component(2).ToString();
            requestOrderMessage.Pid5_3_secondName = pidSegment.Field(5).Component(3).ToString();
            requestOrderMessage.Pid7_datetimeBirth = pidSegment.Field(7).ToString();
            requestOrderMessage.Pid8_AdministrativeSex = pidSegment.Field(8).ToString();

            //Segmento PV (visita)
            var pv1Segment = mensaje.Segments.OfType("PV1").First();
            requestOrderMessage.Pv1_idNumber = pv1Segment.Field(1).ToString();
            requestOrderMessage.Pv2_patientClass = pv1Segment.Field(2).ToString();
            requestOrderMessage.Pv3_assignedPatientLocation = pv1Segment.Field(3).ToString();

            //Segmento ORC
            var orcSegment = mensaje.Segments.OfType("ORC").First();
            requestOrderMessage.Orc1_orderControl = orcSegment.Field(1).ToString();
            requestOrderMessage.Orc2_placerOrderNumer = orcSegment.Field(2).ToString();
            requestOrderMessage.Orc4_placerGroupNumer = orcSegment.Field(4).ToString();
            requestOrderMessage.Orc9_datimeTransaction = orcSegment.Field(9).ToString();
            requestOrderMessage.Orc12_1_idNumber = orcSegment.Field(12).Component(1).ToString();
            requestOrderMessage.Orc13_1_pointOfCare = orcSegment.Field(13).Component(1).ToString();
            requestOrderMessage.Orc17_1_identifier = orcSegment.Field(17).Component(1).ToString();
            requestOrderMessage.Orc17_2_text = orcSegment.Field(17).Component(2).ToString();
            requestOrderMessage.Orc21_1_orginizationName = orcSegment.Field(21).Component(1).ToString();
            requestOrderMessage.Orc21_3_IdNumber = orcSegment.Field(21).Component(3).ToString();

            //Segmento OBR
            var obrSegment = mensaje.Segments.OfType("OBR");

            foreach (var objeto in obrSegment)
            {
                Peticion_obr newObr = new Peticion_obr();
                newObr.Obr1_idOBR = objeto.Field(1).ToString();
                newObr.Obr2_placerOrderNumber = objeto.Field(2).ToString();
                newObr.Obr4_1_Identifier = objeto.Field(4).Component(1).ToString();
                newObr.Obr4_2_text = objeto.Field(4).Component(2).ToString();
                newObr.Obr4_4_AlternateIdentifier = objeto.Field(4).Component(4).ToString();
                newObr.Obr7_ObservationDate = objeto.Field(7).ToString();
                newObr.Obr10_CollectorIdentifier = objeto.Field(10).ToString();
                newObr.Obr15_specimenSource = objeto.Field(15).ToString();
                requestOrderMessage.ListaORB.Add(newObr);
            }

            return requestOrderMessage;
        }

        public PeticionEntrante decodeOrderData(string responseString) {
            var jsonObject = JsonConvert.DeserializeObject<PetitionElements>(responseString);
            PeticionEntrante newOrder = this.decodeMessageData(jsonObject.Mensaje);
            return newOrder;
        }
    }
}

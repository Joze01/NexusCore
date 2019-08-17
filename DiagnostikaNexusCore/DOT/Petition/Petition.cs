using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagnostikaNexusCore.DOT.Petition
{
    public class Petition
    {
        /// <summary>
        /// Generales de la trama msh
        /// </summary>
        private string msh3_sendingApplication; //aplicacion que envia
        private string msh4_sendingFacility; //Lugar de procedencia de peticion
        private string msh5_receivingApplication;  //Aplicacion que recibe
        private string msh6_recivingFacilty; //
        private string msh6_1_idSuministrasnte;
        private string msh7_dateTimeMessage;
        //Tipo de peticion cabecera segun la cabecera msh9> informacion del tipo 
        private string msh9_1_messageCode; //deberian ser OML ya que todos son de laboratorio.
        private string msh9_2_triggerEvent; //Poro lo general es O21 ya que es orden de laboratio. 
        private string msh10_messageControlID;//ID de control para el mensaje.    CORRESPONDE A LA PLANTILLA
        private string msh11_processingID;//D es debugging
        private string msh12_versionId; //2.5.1 
        private string msh15_acceptAcknowledgmentType; //aceptarreconocimiento de tipo AL= siempre
        private string msh16_applicationAcknowledgmentType; //reconocimineto de aplicaicon AL=always

        /// <summary>
        /// Segmento del paciente pid
        /// </summary>
        private string pid1_pdi;//Id de PDI (interno de la peticion)
                                //PID3> informacion de paciente
        private string pid3_1_idNumber;
        private string pid3_4_assigningAutority;
        private string pid5_1_familyName;//Apellidos
        private string pid5_2_givenName;//nombre
        private string pid5_3_secondName;//
                                         //datos extras pid
        private string pid7_datetimeBirth;//fecha de nacimiento
        private string pid8_AdministrativeSex; //CONSULTAR A JULIO llega  1 y espera letras. 

        /// <summary>
        /// Segmento de la visita.
        /// </summary>
        private string pv1_idNumber;
        private string pv2_patientClass;
        private string pv3_assignedPatientLocation;


        /// <summary>
        /// Common Order 
        /// </summary>
        private string orc1_orderControl; //NW means new and Xo means  change order
        private string orc2_placerOrderNumer;
        private string orc4_placerGroupNumer;
        private string orc9_datimeTransaction;
        //Informacion para Ordering Provider orc-12
        private string orc12_1_idNumber;//id provider
        private string orc12_2_familyName;//apelido
        private string orc12_3_givenName;//nombres

        private string orc13_1_pointOfCare;
        private string orc13_9_locationDescription;
        //Informacion de la organizacion de ingreso;
        private string orc17_1_identifier;
        private string orc17_2_text;
        //Informacion del lugar de procedencia. orc21
        private string orc21_1_orginizationName;
        private string orc21_3_IdNumber;


        /// <summary>
        /// Peticion de Observacion OBR
        /// </summary>
        private List<PetitionSpm> OBRList;

        /// <summary>
        /// Peticion de Muestras SPM
        /// </summary>
        private List<PetitionOBR> SPMList;



    }
}

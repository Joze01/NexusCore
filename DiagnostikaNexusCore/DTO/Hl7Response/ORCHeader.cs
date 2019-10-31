using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagnostikaNexusCore.DOT.Hl7Response
{
    public class ORCHeader
    {
        private string orc_1_codigoDeControl;
        private string orc_2_IdSolicitudSiaps;
        private string orc_5_EstatusOrden;
        private string orc_9_FechaDeEnvio;
        private string orc_12_1_CodigoProfesional;
        private string orc_12_2_NombreProfesional;

        public string Orc_1_codigoDeControl { get => orc_1_codigoDeControl; set => orc_1_codigoDeControl = value; }
        public string Orc_2_IdSolicitudSiaps { get => orc_2_IdSolicitudSiaps; set => orc_2_IdSolicitudSiaps = value; }
        public string Orc_5_EstatusOrden { get => orc_5_EstatusOrden; set => orc_5_EstatusOrden = value; }
        public string Orc_9_FechaDeEnvio { get => orc_9_FechaDeEnvio; set => orc_9_FechaDeEnvio = value; }
        public string Orc_12_1_CodigoProfesional { get => orc_12_1_CodigoProfesional; set => orc_12_1_CodigoProfesional = value; }
        public string Orc_12_2_NombreProfesional { get => orc_12_2_NombreProfesional; set => orc_12_2_NombreProfesional = value; }
    }
}

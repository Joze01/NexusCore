using System;
using System.Collections.Generic;

namespace DiagnostikaNexusCore.Models.Openf
{
    public partial class Ologin
    {
        public string LoginName { get; set; }
        public short? LoginCreate { get; set; }
        public short? LoginChange { get; set; }
        public short? LoginDelete { get; set; }
        public short? LoginValidate { get; set; }
        public short? LoginPrint { get; set; }
        public short? LoginDef { get; set; }
        public short? LoginGrupoTrabajo { get; set; }
        public string LoginDescripcion { get; set; }
        public string UsrPasConsulta { get; set; }
    }
}

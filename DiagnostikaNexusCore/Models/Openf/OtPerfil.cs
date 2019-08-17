using System;
using System.Collections.Generic;

namespace DiagnostikaNexusCore.Models.Openf
{
    public partial class OtPerfil
    {
        public DateTime OtPerfilDate { get; set; }
        public decimal OtPerfilOrder { get; set; }
        public int OtPerfilClase { get; set; }
        public float? OtPerfilValor { get; set; }
        public string OtPerfilClaseName { get; set; }
        public string OtPerfilClaseDescrip { get; set; }
    }
}

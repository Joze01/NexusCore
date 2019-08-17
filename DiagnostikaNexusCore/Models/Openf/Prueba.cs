using System;
using System.Collections.Generic;

namespace DiagnostikaNexusCore.Models.Openf
{
    public partial class Prueba
    {
        public decimal Indice { get; set; }
        public string Orden { get; set; }
        public DateTime? Fsolicitud { get; set; }
        public string Origen { get; set; }
        public string Servicio { get; set; }
        public string Diagnostico { get; set; }
        public string Doctor { get; set; }
        public string Hab { get; set; }
        public string Peso { get; set; }
        public string Libre { get; set; }
        public string Diu { get; set; }
        public string Comentario { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apell1 { get; set; }
        public string Apell2 { get; set; }
        public DateTime? Fnac { get; set; }
        public string Sexo { get; set; }
        public string Embarazo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Codigo { get; set; }
        public string Perfil { get; set; }
    }
}

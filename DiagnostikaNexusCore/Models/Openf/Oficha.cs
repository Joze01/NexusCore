using System;
using System.Collections.Generic;

namespace DiagnostikaNexusCore.Models.Openf
{
    public partial class Oficha
    {
        public decimal Custom { get; set; }
        public int UnicoId { get; set; }
        public DateTime FichaDate { get; set; }
        public DateTime? FichaDateCrea { get; set; }
        public DateTime? FechaRecogida { get; set; }
        public DateTime? FechaImpresion { get; set; }
        public DateTime? FechaLimpresion { get; set; }
        public float? Factura { get; set; }
        public float? Freserved { get; set; }
        public DateTime? TimeImpresion { get; set; }
        public DateTime? TimeLimpresion { get; set; }
        public DateTime? Timepet { get; set; }
        public decimal FichaOrder { get; set; }
        public short Impreso { get; set; }
        public short? InHisto { get; set; }
        public short? Precitado { get; set; }
        public short? TotalTest { get; set; }
        public short? ResultTest { get; set; }
        public short? Embarazo { get; set; }
        public short? Nino { get; set; }
        public short? FichaEdad { get; set; }
        public short? FichaTipoEdad { get; set; }
        public short? Terminado { get; set; }
        public short? Pendiente { get; set; }
        public short? ExistePrevio { get; set; }
        public short? Interno { get; set; }
        public short? Urgencia { get; set; }
        public short? Export { get; set; }
        public short? Transmit { get; set; }
        public short? Validado { get; set; }
        public short? Sextra1 { get; set; }
        public short? Sextra2 { get; set; }
        public short? Sextra3 { get; set; }
        public short? Bextra1 { get; set; }
        public short? Bextra2 { get; set; }
        public short? Fichaflag1 { get; set; }
        public short? Fichaflag2 { get; set; }
        public short? OrigenPet { get; set; }
        public string Icu { get; set; }
        public string ExternalCodigo { get; set; }
        public string Medico { get; set; }
        public string DescripMedico { get; set; }
        public string Cia { get; set; }
        public string Servicio { get; set; }
        public string Cama { get; set; }
        public string Operador { get; set; }
        public string Diagnostico { get; set; }
        public string DescripDiag { get; set; }
        public string Cextra1 { get; set; }
        public string Fichacomentario { get; set; }
        public string Fichalinea2 { get; set; }
        public string Fichalinea3 { get; set; }
        public string Diuresis { get; set; }
        public string Peso { get; set; }
        public string FreeField { get; set; }
        public string Fdterminado { get; set; }
        public string Fdprecitado { get; set; }
        public string Fdhistorico { get; set; }
        public string Fdurgencia { get; set; }
        public string Fdfromhost { get; set; }
        public string Fdtransmitido { get; set; }
        public string Fdimpreso { get; set; }
    }
}

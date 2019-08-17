using System;
using System.Collections.Generic;

namespace DiagnostikaNexusCore.Models.Openf
{
    public partial class Ot
    {
        public DateTime TDate { get; set; }
        public DateTime? TDateCrea { get; set; }
        public DateTime? TDateMod { get; set; }
        public DateTime? TDateVal { get; set; }
        public int TParam { get; set; }
        public decimal TCustom { get; set; }
        public int TUnicoId { get; set; }
        public int? TValoracion { get; set; }
        public int TGrupo { get; set; }
        public int? TFamilia { get; set; }
        public int? TPerfil { get; set; }
        public int? TLong { get; set; }
        public float? Resultado { get; set; }
        public float? RInf { get; set; }
        public float? RSup { get; set; }
        public float? VInf { get; set; }
        public float? VSup { get; set; }
        public float? Numdilucion { get; set; }
        public decimal TOrder { get; set; }
        public short? TCount { get; set; }
        public short? TExtra { get; set; }
        public DateTime? TTimeCrea { get; set; }
        public DateTime? TTimeMod { get; set; }
        public DateTime? TTimeVal { get; set; }
        public short? Anormal { get; set; }
        public short? Hilow { get; set; }
        public short? Terminated { get; set; }
        public short? Calculo { get; set; }
        public short? Memo { get; set; }
        public short? TNoprint { get; set; }
        public short? TValidado { get; set; }
        public short? Incongruente { get; set; }
        public short? TCerrado { get; set; }
        public short? TPendMod { get; set; }
        public short? TListas { get; set; }
        public short? Interpretado { get; set; }
        public short? TComentado { get; set; }
        public short? TGrupoTrabajo { get; set; }
        public short? TExterno { get; set; }
        public short? TEtiqueta { get; set; }
        public short? TEdad { get; set; }
        public short? TTipoEdad { get; set; }
        public short? TProyecto { get; set; }
        public short? Onlineflag { get; set; }
        public short? Orderprint { get; set; }
        public short? Inonline { get; set; }
        public short? TEstad { get; set; }
        public short? Numflag3 { get; set; }
        public short? Numflag4 { get; set; }
        public short? TComFlag { get; set; }
        public string TSexo { get; set; }
        public string TMuestra { get; set; }
        public string TUnidades { get; set; }
        public string TCodigoManual { get; set; }
        public string TNombre { get; set; }
        public string Rlinea { get; set; }
        public string TComentario { get; set; }
        public string TDescripMemo { get; set; }
        public string TTipoResult { get; set; }
        public string TModificadoPor { get; set; }
        public string TValidadoPor { get; set; }
        public short? TFromHis { get; set; }
        public string TPerfilCodigo { get; set; }
        public string TPlantilla { get; set; }
        public short? TPlantillaBel { get; set; }
        public short? TPlantillaBse { get; set; }
        public short? TPlantillaEid { get; set; }
        public string Tdterminado { get; set; }
        public string Tdpendiente { get; set; }
        public string Tdfromhost { get; set; }
        public string Tdtransmitido { get; set; }
        public string Tdimpreso { get; set; }
        public string Tdvalidado { get; set; }
        public string Tdanormal { get; set; }
        public string Tdincongruente { get; set; }
        public string Tdcalculado { get; set; }
    }
}

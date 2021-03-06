﻿using System;
using System.Collections.Generic;

namespace TestProject.Models.Openf
{
    public partial class OformuData
    {
        public int VoidCodigo { get; set; }
        public int? VoidReserved { get; set; }
        public int ParCodigo { get; set; }
        public int ParGrupo { get; set; }
        public short? GrupoTrabajo { get; set; }
        public short NumAutomat { get; set; }
        public short? Orden { get; set; }
        public short? NoStad { get; set; }
        public short? TestProyecto { get; set; }
        public short? TestInterpretado { get; set; }
        public short? TestExterno { get; set; }
        public short? TestImprocedente { get; set; }
        public short? TestTimprocedente { get; set; }
        public short? Etiqueta { get; set; }
        public short? Automat { get; set; }
        public short? Especial { get; set; }
        public short? T1 { get; set; }
        public short? T2 { get; set; }
        public short? T3 { get; set; }
        public short? PreResultFlag { get; set; }
        public short? Checkformula { get; set; }
        public short? Absurdvaron { get; set; }
        public short? Absurdhembra { get; set; }
        public short? Absurdnino { get; set; }
        public short? Absurdembarazo { get; set; }
        public short? IncludeValorPositivo { get; set; }
        public short? IncludeValorNegativo { get; set; }
        public short? ReservedSmallint { get; set; }
        public string CodigoManual { get; set; }
        public string TipoResult { get; set; }
        public string CodigoGeneral { get; set; }
        public string ParNombre { get; set; }
        public string Abreviado { get; set; }
        public string Tecnica { get; set; }
        public string PreResult { get; set; }
        public string ParMuestra { get; set; }
        public string Unidades { get; set; }
        public string Inter1 { get; set; }
        public string Inter2 { get; set; }
        public string Inter3 { get; set; }
        public string Inter4 { get; set; }
        public string Inter5 { get; set; }
        public string Ajuste { get; set; }
        public string Familia { get; set; }
        public string FamDescrip { get; set; }
        public string NumEspecial { get; set; }
        public string Unidad2 { get; set; }
        public string Asocglos { get; set; }
        public string Asocgraf { get; set; }
        public string Alternate1 { get; set; }
        public string CodigosAut1 { get; set; }
        public string CodigosAut2 { get; set; }
        public string CodigosAut3 { get; set; }
        public string DescripAut1 { get; set; }
        public string DescripAut2 { get; set; }
        public string DescripAut3 { get; set; }
        public string MuestraAut1 { get; set; }
        public string MuestraAut2 { get; set; }
        public string MuestraAut3 { get; set; }
        public string Formula { get; set; }
        public float? ValorInferior1 { get; set; }
        public float? ValorInferior2 { get; set; }
        public float? ValorInferior3 { get; set; }
        public float? ValorInferior4 { get; set; }
        public float? ValorSuperior1 { get; set; }
        public float? ValorSuperior2 { get; set; }
        public float? ValorSuperior3 { get; set; }
        public float? ValorSuperior4 { get; set; }
        public float? MinInter1 { get; set; }
        public float? MinInter2 { get; set; }
        public float? MinInter3 { get; set; }
        public float? MinInter4 { get; set; }
        public float? MinInter5 { get; set; }
        public float? MaxInter1 { get; set; }
        public float? MaxInter2 { get; set; }
        public float? MaxInter3 { get; set; }
        public float? MaxInter4 { get; set; }
        public float? MaxInter5 { get; set; }
        public float? Porcentaje1 { get; set; }
        public float? Porcentaje2 { get; set; }
        public float? Porcentaje3 { get; set; }
        public float? Porcentaje4 { get; set; }
        public float? Porcentaje5 { get; set; }
        public float? PrecioBase { get; set; }
        public float? Tarifa1 { get; set; }
        public float? Tarifa2 { get; set; }
        public float? Tarifa3 { get; set; }
        public float? Tarifa4 { get; set; }
        public float? Tarifa5 { get; set; }
        public float? Variacion { get; set; }
        public float? Facunidad2 { get; set; }
        public float? Maxrl { get; set; }
        public float? Minrl { get; set; }
        public float? Maxescala { get; set; }
        public float? Minescala { get; set; }
        public float? FacAut1 { get; set; }
        public float? FacAut2 { get; set; }
        public float? FacAut3 { get; set; }
        public float? Delta { get; set; }
        public float? Deltafactor { get; set; }
        public float? Panicmax { get; set; }
        public float? Panicmin { get; set; }
        public float? Absurdmax { get; set; }
        public float? Absurdmin { get; set; }
        public float? IncludeValorMayor { get; set; }
        public float? IncludeValorMenor { get; set; }
        public int? AnormalInclude1 { get; set; }
        public int? AnormalInclude2 { get; set; }
        public int? AnormalInclude3 { get; set; }
        public int? AnormalInclude4 { get; set; }
        public int? AnormalCheck1 { get; set; }
        public int? AnormalCheck2 { get; set; }
        public int? AnormalCheck3 { get; set; }
        public int? AnormalCheck4 { get; set; }
        public int? NormalCheck1 { get; set; }
        public int? NormalCheck2 { get; set; }
        public int? NormalCheck3 { get; set; }
        public int? NormalCheck4 { get; set; }

        public virtual Olgrupos NumAutomatNavigation { get; set; }
        public virtual Ogrupos ParGrupoNavigation { get; set; }
    }
}

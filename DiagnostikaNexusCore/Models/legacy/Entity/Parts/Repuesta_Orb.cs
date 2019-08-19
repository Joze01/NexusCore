using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Repuesta_Orb
/// </summary>
public class Repuesta_Orb
{
    /// <summary>
    /// DEBE SER INCREMENTAL
    /// </summary>
    private long obr_1_IdOBR;
    private string obr_2_PlacerOrdeNumber;//(DetalleSoliciturd)

    private string obr_4_1_Identifier;
    private string obr_4_2_Text;
    private string obr_4_3_NameOfCodingSystem; //L
    private string obr_4_4_AlternateIdentifier;
    private string obr_4_5_AlternateText;
    private string obr_8_ObservationEndDateTime;
    private string obr_10_CollectorIdentifier;
    private string obr_16_1_IdNumber;
    private string obr_16_2_FamilyName;
    private string obr_22_ResultReptStatusChangeDateTime;
    private string obr_24_DiagnosticServiceID; // HM= hemato, MB= microbiologia, ch=Bioquimica
    private string obr_25_ResultStatus; // = F
    private Respuesta_obx_cualitativo obx_Cualitativo;
    private List<Respuesta_obx> listObxCuantitativos;


    public Repuesta_Orb()
    {
        Obx_Cualitativo = new Respuesta_obx_cualitativo();
        ListObxCuantitativos = new List<Respuesta_obx>();
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public string Obr_2_PlacerOrdeNumber { get => obr_2_PlacerOrdeNumber; set => obr_2_PlacerOrdeNumber = value; }
    public string Obr_4_1_Identifier { get => obr_4_1_Identifier; set => obr_4_1_Identifier = value; }
    public string Obr_4_2_Text { get => obr_4_2_Text; set => obr_4_2_Text = value; }
    public string Obr_4_3_NameOfCodingSystem { get => obr_4_3_NameOfCodingSystem; set => obr_4_3_NameOfCodingSystem = value; }
    public string Obr_4_4_AlternateIdentifier { get => obr_4_4_AlternateIdentifier; set => obr_4_4_AlternateIdentifier = value; }
    public string Obr_4_5_AlternateText { get => obr_4_5_AlternateText; set => obr_4_5_AlternateText = value; }
    public string Obr_8_ObservationEndDateTime { get => obr_8_ObservationEndDateTime; set => obr_8_ObservationEndDateTime = value; }
    public string Obr_10_CollectorIdentifier { get => obr_10_CollectorIdentifier; set => obr_10_CollectorIdentifier = value; }
    public string Obr_16_1_IdNumber { get => obr_16_1_IdNumber; set => obr_16_1_IdNumber = value; }
    public string Obr_16_2_FamilyName { get => obr_16_2_FamilyName; set => obr_16_2_FamilyName = value; }
    public string Obr_22_ResultReptStatusChangeDateTime { get => obr_22_ResultReptStatusChangeDateTime; set => obr_22_ResultReptStatusChangeDateTime = value; }
    public string Obr_24_DiagnosticServiceID { get => obr_24_DiagnosticServiceID; set => obr_24_DiagnosticServiceID = value; }
    public string Obr_25_ResultStatus { get => obr_25_ResultStatus; set => obr_25_ResultStatus = value; }
    public Respuesta_obx_cualitativo Obx_Cualitativo { get => obx_Cualitativo; set => obx_Cualitativo = value; }
    public List<Respuesta_obx> ListObxCuantitativos { get => listObxCuantitativos; set => listObxCuantitativos = value; }
    public long Obr_1_IdOBR { get => obr_1_IdOBR; set => obr_1_IdOBR = value; }
}
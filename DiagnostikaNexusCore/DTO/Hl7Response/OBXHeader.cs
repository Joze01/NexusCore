using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagnostikaNexusCore.DOT.Hl7Response
{
    public class OBXHeader
    {
        string obx_1_IdObx;
        string obx_2_DataType; //String,Num
        string obx_3_ExamenIdRequest;
        string obx_4_ResultId;    //1-7 segun catalogo
        string obx_5_Result; //Normal,
    }
}

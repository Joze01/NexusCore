using System;
using System.Collections.Generic;

namespace TestProject.Models.Openf
{
    public partial class PreData
    {
        public string PreDataCode { get; set; }
        public string PreDataMask { get; set; }
        public string PreDataReport { get; set; }
        public short? PreDataFreport { get; set; }
        public short? PreDataFsave { get; set; }

        public virtual PreListas PreDataCodeNavigation { get; set; }
    }
}

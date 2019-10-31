using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagnostikaNexusCore.DOT
{
    public class ResultHistory
    {
        decimal order;
        string identification;
        DateTime dateValue;
        int param;
        string result;
        string comment;
        string study;
        string template;
        string bElement;
        string bSubElement;
        string eElement;
        string responsableId;
        string tFromHis;
        string tValidate;

        public decimal Order { get => order; set => order = value; }
        public string Identification { get => identification; set => identification = value; }
        public DateTime DateValue { get => dateValue; set => dateValue = value; }
        public int Param { get => param; set => param = value; }
        public string Result { get => result; set => result = value; }
        public string Comment { get => comment; set => comment = value; }
        public string Study { get => study; set => study = value; }
        public string Template { get => template; set => template = value; }
        public string BElement { get => bElement; set => bElement = value; }
        public string BSubElement { get => bSubElement; set => bSubElement = value; }
        public string EElement { get => eElement; set => eElement = value; }
        public string TFromHis { get => tFromHis; set => tFromHis = value; }
        public string TValidate { get => tValidate; set => tValidate = value; }
        public string ResponsableId { get => responsableId; set => responsableId = value; }
    }
}

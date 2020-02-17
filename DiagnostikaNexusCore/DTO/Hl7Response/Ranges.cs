using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagnostikaNexusCore.DTO.Hl7Response
{
    public class Ranges
    {
        private float? valorInferior;
        private float? valorSuperior;

        public float? ValorInferior { get => valorInferior; set => valorInferior = value; }
        public float? ValorSuperior { get => valorSuperior; set => valorSuperior = value; }
    }
}

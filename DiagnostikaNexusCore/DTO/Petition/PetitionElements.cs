using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagnostikaNexusCore.DOT.Petition
{
    public class PetitionElements
    {
        private string token;
        private string mensaje;
        private string checksum;



        public PetitionElements()
        {

        }

        public PetitionElements(string token, string mensaje, string checksum)
        {
            this.Token = token;
            this.Mensaje = mensaje;
            this.checksum = checksum;
        }

        public string Token
        {
            get
            {
                return token;
            }

            set
            {
                token = value;
            }
        }

        public string Mensaje
        {
            get
            {
                return mensaje;
            }

            set
            {
                mensaje = value;
            }
        }

        public string Checksum
        {
            get
            {
                return checksum;
            }

            set
            {
                checksum = value;
            }
        }
    }
}

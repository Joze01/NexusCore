using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagnostikaNexusCore.BLL.Hl7RequestParser
{
    public class RequestBuilderUtil
    {
        public string compuseOrderId(string orderId) {
            DateTime currentDate = DateTime.Now;
            return currentDate.ToString("yyMMdd") + orderId;
        }

        public DateTime currentDateFormated() {
            DateTime currentDate = DateTime.Now;
            var formatedDate = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 00, 00, 00);
            return formatedDate;
        }

        public List<string> getLastNames(string lastNames) {
            return lastNames.Split(" ").ToList<String>();
        }

        public short getAges(string dateOfBirth) {
            DateTime birthDay = DateTime.ParseExact(dateOfBirth + " 00:00:00", "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            DateTime currentDate = DateTime.Now;
            int age = (currentDate - birthDay).Days / 365;
            return short.Parse(age.ToString());
        }

        public string getGender(string ageId)
        {
            if (ageId == "2")
            {
                return "F";
            }
            else
            {
                return "M";
            }
        }
    }
}

using DiagnostikaNexusCore.Models.hlseven;
using DiagnostikaNexusCore.Models.PublicRequest;
using DiagnostikaNexusCore.Models.PublicResponses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagnostikaNexusCore.BLL.Security
{
    public class Autentication
    {
        private readonly hl7Context _hl7Context;

        public Autentication( hl7Context hl7Context)
        {
            _hl7Context = hl7Context;
        }

        public Checkin login(string requestBody) {
            UserLogin userData = new UserLogin();
            userData = JsonConvert.DeserializeObject<UserLogin>(requestBody);
            List<Users> userCount = _hl7Context.Users.Where(user => user.UserId == userData.AppUser && user.Password == userData.Password).ToList();
            Checkin checkinResult = new Checkin();
            checkinResult.estado = "false";
            checkinResult.mensaje = "Permiso Denegado";
            if (userCount.Count > 0)
            {
                checkinResult.estado="true";
                checkinResult.mensaje = "OK";
                var token = generateToken();
                checkinResult.Token = token;
                createSession(token, userData.AppUser);
            }
            return checkinResult;
        }

        private string generateToken() {
            byte[] time = BitConverter.GetBytes(DateTime.UtcNow.ToBinary());
            byte[] key = Guid.NewGuid().ToByteArray();
            string token = Convert.ToBase64String(time.Concat(key).ToArray());
            return token;
        }

        private void createSession(string token, string user) {
            Sessions newSession = new Sessions();
            newSession.Token = token;
            newSession.UserId = user;
            _hl7Context.Sessions.Add(newSession);
            _hl7Context.SaveChanges();
        }

        public bool validateToken(string tokenString){
           var result = _hl7Context.Sessions.Where(session => session.Token == tokenString).ToList();
            if (result.Count > 0)
            {
                _hl7Context.Sessions.RemoveRange(_hl7Context.Sessions.Where(session=> session.Token == tokenString));
                _hl7Context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}

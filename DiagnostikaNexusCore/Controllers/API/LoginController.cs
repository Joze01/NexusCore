using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiagnostikaNexusCore.BLL.Security;
using DiagnostikaNexusCore.Models.hlseven;
using DiagnostikaNexusCore.Models.PublicRequest;
using Microsoft.AspNetCore.Mvc;

namespace DiagnostikaNexusCore.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly hl7Context _hl7Context;

        public LoginController(hl7Context hl7Context)
        {
            _hl7Context = hl7Context;
        }

        [HttpGet]
        public async Task<Checkin> checkinAsync()
        {
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                var responseBody = await reader.ReadToEndAsync();
                Autentication loginSecurity = new Autentication(_hl7Context);
                return loginSecurity.login(responseBody);
            }
        }
    }
}
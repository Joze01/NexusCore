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
    public class CheckinController : Controller
    {
        private readonly hl7Context _hl7Context;

        public CheckinController(hl7Context hl7Context)
        {
            _hl7Context = hl7Context;
        }

        [HttpPost]
        public async Task<String> checkinAsync()
        {
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                var responseBody = await reader.ReadToEndAsync();
                System.Diagnostics.Debug.Print(responseBody);
                Autentication loginSecurity = new Autentication(_hl7Context);
                var loginObject = loginSecurity.login(responseBody);
                var jsonResult = "{\"Token\":\""+loginObject.Token+"\",\"mensaje\":\"" + loginObject.mensaje + "\",\"estado\":\"" + loginObject.estado + "\"}";
                return jsonResult;
            }
        }
    }
}
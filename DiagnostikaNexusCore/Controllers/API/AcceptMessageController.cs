using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiagnostikaNexusCore.BLL.Hl7RequestParser;
using DiagnostikaNexusCore.Models.hlseven;
using DiagnostikaNexusCore.Models.Openf;
using DiagnostikaNexusCore.Models.PublicResponses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DiagnostikaNexusCore.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcceptMessageController : ControllerBase
    {
        private readonly OpenfContext _context;
        private readonly hl7Context _hl7Context;

        public AcceptMessageController(OpenfContext context, hl7Context hl7Context)
        {
            _context = new OpenfContext();
            _hl7Context = new hl7Context();
        }

        [HttpPost]
        public async Task<String> AcceptMessage()
        {
            RequestBuilder requestBuilder = new RequestBuilder(_context, _hl7Context);
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                var responseBody = await reader.ReadToEndAsync();
                System.Diagnostics.Debug.Print(responseBody);
                var resultaMessage = await requestBuilder.saveOrder(responseBody);
                var jsonResult = "{\"Mensaje\":\"" + resultaMessage.Mensaje + "\",\"Estado\":\"" + resultaMessage.Estado + "\"}";
                return jsonResult;
            }
        }
    }
}
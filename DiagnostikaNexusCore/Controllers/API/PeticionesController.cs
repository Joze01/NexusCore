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
    public class PeticionesController : ControllerBase
    {
        private readonly OpenfContext _context;
        private readonly hl7Context _hl7Context;

        public PeticionesController(OpenfContext context, hl7Context hl7Context)
        {
            _context = context;
            _hl7Context = hl7Context;
        }

        [HttpPost]
        public async Task<AcceptMessage> AcceptMessage()
        {
            RequestBuilder requestBuilder = new RequestBuilder(_context, _hl7Context);
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                var responseBody = await reader.ReadToEndAsync();
                return await requestBuilder.saveOrder(responseBody);
            }
        }

    }
}
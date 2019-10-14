using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DiagnostikaNexusCore.BLL.Hl7ResponseBuilder;
using DiagnostikaNexusCore.DOT;
using DiagnostikaNexusCore.DAL.ResponseBuilder;
using DiagnostikaNexusCore.Models.PublicResponses;
using DiagnostikaNexusCore.BLL.Hl7RequestParser;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DiagnostikaNexusCore.DOT.Petition;
using Microsoft.EntityFrameworkCore;
using DiagnostikaNexusCore.Models.Openf;

namespace DiagnostikaNexusCore.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private RBDataProvider response = new RBDataProvider();

        private readonly openfContext _context;

        public TestController(openfContext context)
        {
            _context = context;
        }

        // GET: api/Transacciones
        [HttpGet]
        public async Task<List<ResultHistory>> getData()
        {
            return await response.FindResultHistory(180817842);
        }

        [HttpPost]
        public async Task<AcceptMessage> AcceptMessage() {
            RequestBuilder requestBuilder = new RequestBuilder(_context);
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
             {
                var responseBody = await reader.ReadToEndAsync();
                return await requestBuilder.saveOrder(responseBody);
               
            }
        }

    }


}
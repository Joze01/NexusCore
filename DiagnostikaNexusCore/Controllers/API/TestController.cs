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
using DiagnostikaNexusCore.Models.hlseven;

namespace DiagnostikaNexusCore.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private RBDataProvider response = new RBDataProvider();

        private readonly OpenfContext _context;
        private readonly hl7Context _hl7Context;

        public TestController(OpenfContext context, hl7Context hl7Context)
        {
            _context = context;
            _hl7Context = hl7Context;
        }
       
        [HttpGet]
        public async Task<List<ResultHistory>> getDataAsync()
        {
            RBDataProvider provider = new RBDataProvider();
            var searchResult = await provider.FindResultHistory(191028164);

            var rangos = await provider.getRangosAsync(searchResult[0]);



            return await provider.FindResultHistory(191028164);


        }
        /*
        [HttpPost]
        public async Task<AcceptMessage> AcceptMessage() {
            RequestBuilder requestBuilder = new RequestBuilder(_context,_hl7Context);
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
             {
                var responseBody = await reader.ReadToEndAsync();
                return await requestBuilder.saveOrder(responseBody);
               
            }
        }*/
    }


}
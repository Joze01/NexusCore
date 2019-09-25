using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DiagnostikaNexusCore.BLL.Hl7ResponseBuilder;
using DiagnostikaNexusCore.DOT;
using DiagnostikaNexusCore.DAL.ResponseBuilder;

namespace DiagnostikaNexusCore.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private RBDataProvider response = new RBDataProvider();

        // GET: api/Transacciones
        [HttpGet]
        public async Task<List<ResultHistory>> getData()
        {
            return await response.FindResultHistory(180817842);
        }

    }


}
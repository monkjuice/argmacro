using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Service;
using Service.Interfaces;

namespace argmacro.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BCRAController : ControllerBase
    {

        private readonly IBCRAService bcraService;

        public BCRAController(ILogger<BCRAController> logger)
        {
        }

        [HttpGet]
        public string GetBCRAVariable(int? type, int? page)
        {
            var catalogModel = bcraService.monetaryBasesOverTime();
            //return Ok(catalogModel);
        }
    }
}




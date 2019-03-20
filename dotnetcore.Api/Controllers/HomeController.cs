using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcore.Api.Controllers
{
    [Produces("application/json")]
    [Route("[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private ILogger<HomeController> _logger;

        public string Str;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get(string str)
        {
            List<string> strs = new List<string> {
                str,"Post","Get","Put"
            };

            _logger.LogInformation("Info");
            _logger.LogError("Err");
            _logger.LogWarning("Warn");

            return strs;
        }


        [HttpGet]
        public ActionResult<string> Post(string str)
        {
            return $"__111__{str}_22321___";
        }
    }
}

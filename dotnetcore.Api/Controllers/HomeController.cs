using dotnetcore.core;
using dotnetcore.core.Core;
using dotnetcore.core.Entites;
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
        private UserContext _context;
        private IUserVisit _userVisit;


        public HomeController(ILogger<HomeController> logger, UserContext context, IUserVisit userVisit)
        {
            _logger = logger;
            _context = context;
            _userVisit = userVisit;
        }

      //  [HttpGet]
      //public ActionResult<IEnumerable<string>> Get(string str)
      //  {
      //      List<string> strs = new List<string> {
      //          str,"Post","Get","Put"
      //      };

      //      _logger.LogInformation("Info");
      //      _logger.LogError("Err");
      //      _logger.LogWarning("Warn");

      //      return strs;
      //  }


        [HttpGet]
        public ActionResult<IEnumerable<User>> Post(string str)
        {
            return _userVisit.GetUserAll();
        }
    }
}

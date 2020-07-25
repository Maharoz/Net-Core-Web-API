using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CompanyEmployees.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private ILoggerManager _logger;

       public WeatherForecastController(ILoggerManager logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInfo("Here is info message from values controller");
            _logger.LogDebug("Here is debug message from values controller");
            _logger.LogWarn("Here is warn message from values controller");
            _logger.LogError("Here is error message from values controller");

            return new string[]
            {
                "value1","value2"
            };
        }
    }
}

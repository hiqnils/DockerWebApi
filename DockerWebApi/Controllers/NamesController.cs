using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DockerWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NamesController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<NamesController> _logger;

        public NamesController(ILogger<NamesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            Random random = new Random();
            var randomNumber = random.Next(1, 6);
            return new[]
            {
                Environment.MachineName,
                randomNumber.ToString()
            };
        }
    }
}

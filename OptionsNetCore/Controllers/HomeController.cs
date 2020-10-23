using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using OptionsNetCore.Core.Options.Redis;
using OptionsNetCore.Services;
using System;

namespace OptionsNetCore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IOptions<RedisOptions> _options;
        private readonly IOptionsSnapshot<RedisOptions> _snapshot;
        private readonly IOptionsMonitor<RedisOptions> _monitor;

        public HomeController(
            IOptions<RedisOptions> options,
            IOptionsSnapshot<RedisOptions> snapshot,
            IOptionsMonitor<RedisOptions> monitor)
        {
            this._options = options;
            this._snapshot = snapshot;
            this._monitor = monitor;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = new
            {
                options = this._options.Value,
                snapshot = this._snapshot.Value,
                monitor = this._monitor.CurrentValue
            };

            return Ok(data);
        }
    }
}

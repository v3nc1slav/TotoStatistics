namespace TotoStatistics.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using TotoStatistics.Models;
    using TotoStatistics.Services.Toto;
    using TotoStatistics.ViewsModels;

    [Authorize]
    public class TotoController : Controller
    {
        private readonly ILogger<TotoController> _logger;
        private readonly ISixOutOfForty_nineServices sixOutOfForty_Nine;

        public TotoController(ILogger<TotoController> logger, ISixOutOfForty_nineServices sixOutOfForty_Nine)
        {
            _logger = logger;
            this.sixOutOfForty_Nine = sixOutOfForty_Nine;
        }

        [HttpGet]
        public async Task<IActionResult> SixOutOfForty_nine()
        {
            _logger.LogInformation("SixOutOfForty-nine");
            var viewModel = new SixOutOfForty_nineViewModel
            {
                ListToto = sixOutOfForty_Nine.GetListAsync().Result
            };
            return this.View(viewModel);
        }
    }
}

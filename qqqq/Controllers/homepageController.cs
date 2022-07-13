using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using qqqq.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace qqqq.Controllers
{
    public class homepageController : Controller
    {
        private readonly ILogger<homepageController> _logger;

        public homepageController(ILogger<homepageController> logger)
        {
            _logger = logger;
        }

        public IActionResult homepage()
        {
            return View();
        }
        public IActionResult enterpage()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

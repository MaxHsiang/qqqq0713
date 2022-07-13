using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace qqqq.Controllers
{
    public class BackIndexController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

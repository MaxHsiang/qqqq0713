using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace qqqq.Controllers
{
    public class petsController : Controller
    {
        public IActionResult pets()
        {
            return View();
        }
        public IActionResult showpets()
        {
            return View();
        }
    }
}


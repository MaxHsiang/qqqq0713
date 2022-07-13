using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace qqqq.Controllers
{
    public class aboutController : Controller
    {
        public IActionResult about()
        {
            return View();
        }
    }
}

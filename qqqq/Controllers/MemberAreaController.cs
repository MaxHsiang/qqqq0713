using Microsoft.AspNetCore.Mvc;
using qqqq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjHomeLess_R.Controllers
{
    public class MemberAreaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        public IActionResult MemberArea()
        {
            return View();
        }
        public IActionResult MemberEdoit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MemberEdoit(Member mem)
        {
            return RedirectToAction("MemberDoneList");
        }
        public IActionResult MemberAreatry()
        {
            return View();
        }

        public IActionResult MemberDoneList()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MemberDoneList(Member mem)
        {
            return View();
        }
    }
}

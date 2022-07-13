using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Pet.ViewModels;

using prjMVCDemo.vModel;
using qqqq.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace prjHomeLess_R.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private 我救浪Context _context = new 我救浪Context();
        private IWebHostEnvironment _environment;
        //注入IWebHostEnvironment




        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment p)
        {
            _logger = logger;
            _environment = p;
        }

        //=====================================
        public IActionResult Index()
        {


            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_LOGIN_USER))

            {
                return RedirectToAction("Login");
            }
            ViewBag.MEM = HttpContext.Session.GetString(CDictionary.SK_LOGIN_USER);
            return View();

        }

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]

        public IActionResult Login(string txtAccount, string txtPassword)
        {
            //資料庫檔案 ==================================================================
            Member mem = _context.Members.FirstOrDefault(m => m.Email.Equals(txtAccount));

            if (mem != null)
            {
                if (mem.Password.Equals(txtPassword))
                {
                    CLoginView cm = new CLoginView();
                    //string jsonUser = JsonSerializer.Serialize(cm.);
                    cm._Member = mem;
                    HttpContext.Session.SetString(CDictionary.SK_LOGIN_USER, cm.Name);


                    return RedirectToAction("homepage", "Home");
                }
            }

            return View();

        }
        public IActionResult City()
        {
            var city = _context.Cities.Select(c => c.CityName).Distinct();
            //return Json(city);


            return Json(city);
        }
        //public IActionResult CityId()
        //{
        //    var cityid = _context.Cities.Select(c => c.CityName).Distinct();
        //    return Json(cityid);

        //}

        public IActionResult Register()
        {

            return View();

        }

        [HttpPost]

        public IActionResult Register(Member mem, IFormFile File)
        {

            //         if(mem.Name!=null)
            //return RedirectToAction("Login");
            //         if (mem.Photo != null)
            //         {
            //             string pName = Guid.NewGuid().ToString() + ".jpg";
            //             Debug.WriteLine(pName);
            //             File.CopyTo(new FileStream(_environment.WebRootPath + "/Images/" + pName, FileMode.Create));
            //             mem.Photo = pName;
            //             //todo照片上傳
            //         }
         
                _context.Members.Add(mem);
                _context.SaveChanges();
            
            //todo

            return View("Login");
         
        }


     


        public IActionResult Registertry()
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
        public IActionResult homepage()
        {
            return View();
        }
    }
}

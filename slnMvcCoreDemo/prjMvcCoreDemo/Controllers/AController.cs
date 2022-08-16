using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prjLottoApp.Models;
using prjMvcCoreDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace prjMvcCoreDemo.Controllers
{
    public class AController : Controller
    {
        public string demoJson2Object()
        {
            string json = demoObject2Json();
            TProduct x = JsonSerializer.Deserialize<TProduct>(json);
            return x.FName + " / " + x.FPrice.ToString();
        }
        public string demoObject2Json()
        {
            TProduct x = new TProduct();
            x.FName = "PS5";
            x.FQty = 2;
            x.FPrice = 9750;
            return JsonSerializer.Serialize(x);
        }

        public ActionResult showCountBySession()
        {
            int count = 0;

            if (HttpContext.Session.Keys.Contains("KK"))
                count = (int)HttpContext.Session.GetInt32("KK");
            
            count++;
            HttpContext.Session.SetInt32("KK", count);
            ViewBag.COUNT = count;
            return View();
        }
        public string sayHello()
        {
            return "Hello ASP.NET Core MVC";
        }
        public string lotto()
        {
            return (new CLottoGen()).getLotto();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

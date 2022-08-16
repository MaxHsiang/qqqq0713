using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using prjMvcCoreDemo.Models;
using prjMvcCoreDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace prjMvcCoreDemo.Controllers
{
    public class ProductController : Controller
    {
        private IWebHostEnvironment _enviroment;
        public ProductController(IWebHostEnvironment p)
        {
            _enviroment = p;
        }

        public IActionResult List(CKeywordViewModel vModel)
        {
            dbDemoContext db = new dbDemoContext();
            IEnumerable<TProduct> datas = null;
            if (string.IsNullOrEmpty(vModel.txtKeyword))
            {
                datas = from t in db.TProducts
                        select t;
            }
            else
            {
                datas = db.TProducts.Where(t => t.FName.Contains(vModel.txtKeyword));
            }
            return View(datas);
        }        

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(TProduct p)
        {
            dbDemoContext db = new dbDemoContext();
            db.TProducts.Add(p);
            db.SaveChanges();
            return RedirectToAction("List");
        }
        public ActionResult Edit(int? id)
        {
            dbDemoContext db = new dbDemoContext();
            TProduct prod = db.TProducts.FirstOrDefault(t => t.FId == id);
            if (prod == null)
                return RedirectToAction("List");
            return View(prod);
        }
        [HttpPost]
        public ActionResult Edit(CProductViewModel p)
        {

            dbDemoContext db = new dbDemoContext();
            TProduct prod = db.TProducts.FirstOrDefault(t => t.FId == p.FId);
            if (prod != null)
            {
                if (p.photo != null)
                {
                    string pName = Guid.NewGuid().ToString() + ".jpg";
                    p.photo.CopyTo(new FileStream(
                        _enviroment.WebRootPath + "/images/" + pName,FileMode.Create));
                    prod.FImagePath = pName;
                }
                prod.FName = p.FName;
                prod.FCost = p.FCost;
                prod.FPrice = p.FPrice;
                prod.FQty = p.FQty;
            }
            db.SaveChanges();
            return RedirectToAction("List");
        }
        public IActionResult Delete(int? id)
        {
            dbDemoContext db = new dbDemoContext();
            TProduct prod = db.TProducts.FirstOrDefault(t => t.FId == id);
            if (prod != null)
            {
                db.TProducts.Remove(prod);
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }
    }
}

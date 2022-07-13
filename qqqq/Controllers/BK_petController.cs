using Microsoft.AspNetCore.Mvc;
using prjHomeLess.ViewModel;
using qqqq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace qqqq.Controllers
{
    public class BK_petController : Controller
    {
        public IActionResult petList()
        {
            我救浪Context db = new 我救浪Context();
            var datas = from p in db.Products
                        where p.IsPet == true
                        select p;
            List<CPet> list = new List<CPet>();
            foreach (Product p in datas)
            {
                CPet pet = new CPet();
                pet.Product = p;
                list.Add(pet);
            }
            return View(list);
        }

        //新增浪浪
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product p)
        {
            我救浪Context db = new 我救浪Context();

            db.Products.Add(p);
            db.SaveChanges();
            return RedirectToAction("petList");
        }

        //刪除浪浪
        public IActionResult Delete(int? id)
        {
            我救浪Context db = new 我救浪Context();
            Product product = db.Products.FirstOrDefault(p => p.ProductId == id);
            if (product != null)
            {
                db.Products.Remove(product);
                db.SaveChanges();
            }
            return RedirectToAction("petList");
        }

        //修改浪浪
        public IActionResult Edit(int? id)
        {
            我救浪Context db = new 我救浪Context();
            Product product = db.Products.FirstOrDefault(p => p.ProductId == id);
            if (product == null)
                return RedirectToAction("petList");
            return View(new CPet(product));
        }
        [HttpPost]
        public IActionResult Edit(Product pd)
        {
            我救浪Context db = new 我救浪Context();
            Product product = db.Products.FirstOrDefault(p => p.ProductId == pd.ProductId);
            if (product != null)
            {
                product.ProductName = pd.ProductName;
                product.Description = pd.Description;
                db.SaveChanges();
            }
            return RedirectToAction("petList");
        }
    }
}


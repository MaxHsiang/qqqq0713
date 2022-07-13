using Microsoft.AspNetCore.Mvc;
using qqqq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using qqqq.ViewModels;
using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace qqqq.Controllers
{
    public class shoppingController : Controller
    {
        public IActionResult shopping()
        {
            return View();
        }
        public IActionResult shoppingRow()
        {
            我救浪Context db = new 我救浪Context();
            var datas = db.Products.Where(p => p.IsPet == false).ToList();
            List<CProductShow> list = new List<CProductShow>();
            foreach (Product p in datas)
            {
                CProductShow cprod = new CProductShow();
                cprod.product = p;
                if (p.Photos.Any())
                    cprod.Photos = p.Photos.ToList();
                list.Add(cprod);
            }
            return PartialView(list);
        }
        public IActionResult shoppingCol()
        {
            我救浪Context db = new 我救浪Context();
            var datas = db.Products.Where(p => p.IsPet == false).ToList();
            List<CProductShow> list = new List<CProductShow>();
            foreach (Product p in datas)
            {
                CProductShow cprod = new CProductShow();
                cprod.product = p;
                if (p.Photos.Any())
                    cprod.Photos = p.Photos.ToList();
                list.Add(cprod);
            }
            return PartialView(list);
        }
        public IActionResult ShowProduct(int id)
        {
            CProductShow CprodShow = new CProductShow();
            Product cProd = (new 我救浪Context()).Products.FirstOrDefault(p => p.ProductId == id);
            CprodShow.product = cProd;
            if (cProd.Photos.Any())
                CprodShow.Photos = cProd.Photos.ToList();
            return View(CprodShow);
        }
        [HttpPost]
        public IActionResult ShowProduct(CShoppingCart vModel)
        {
            string jsonCart = "";
            List<CShoppingCart> list = null;
            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_購物車商品列表))
                list = new List<CShoppingCart>();
            else
            {
                jsonCart = HttpContext.Session.GetString(CDictionary.SK_購物車商品列表);
                list = JsonSerializer.Deserialize<List<CShoppingCart>>(jsonCart);
            }
            CProductShow Cprod = new CProductShow();
            Product Prod = (new 我救浪Context()).Products.FirstOrDefault(p => p.ProductId == vModel.CartId);
            Cprod.product = Prod;
            Cprod.Photos = (new 我救浪Context()).Photos.Where(p => p.ProductId == Prod.ProductId).ToList();
            CShoppingCart item = new CShoppingCart()
            {
                CartId = vModel.CartId,
                CartName = Prod.ProductName,
                CartPhoto = Cprod.Photos[0].PictureName,
                CartCount = vModel.CartCount,
                CartPrice = (decimal)Prod.Price
            };
            list.Add(item);
            jsonCart = JsonSerializer.Serialize(list);
            HttpContext.Session.SetString(
                CDictionary.SK_購物車商品列表, jsonCart);


            return View(Cprod);
        }
        public IActionResult CartView()
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_購物車商品列表))
            {
                string jsonCart = HttpContext.Session.GetString(CDictionary.SK_購物車商品列表);

                List<CShoppingCart> cart = JsonSerializer.Deserialize<List<CShoppingCart>>(jsonCart);
                return View(cart);
            }
            else
                return RedirectToAction("Shopping");
        }
        public IActionResult Pay(int? price)
        {
            if (price != null)
            {
                return View((int)price);
            }
            else
                return RedirectToAction("CartView");
        }
    }
}

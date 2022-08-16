using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prjMvcCoreDemo.Models;
using prjMvcCoreDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace prjMvcCoreDemo.Controllers
{
    public class ShoppingController : Controller
    {
        public IActionResult CartView()
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_已經購買的_商品們_列表))
            {
                string jsonCart = HttpContext.Session.GetString(CDictionary.SK_已經購買的_商品們_列表);
                List<CShoppingCartItem> cart = JsonSerializer.Deserialize<List<CShoppingCartItem>>(jsonCart);
                return View(cart);
            }
            else
                return RedirectToAction("List");
        }
        public IActionResult List()
        {
            var datas = from t in (new dbDemoContext()).TProducts
                        select t;
            List<CProductViewModel> list = new List<CProductViewModel>();
            foreach (TProduct t in datas)
            {
                CProductViewModel p = new CProductViewModel();
                p.product = t;
                list.Add(p);
            }
            return View(list);
        }
        public ActionResult AddToCart(int? id)
        {
            dbDemoContext db = new dbDemoContext();
            TProduct prod = db.TProducts.FirstOrDefault(t => t.FId == id);
            if (prod == null)
                return RedirectToAction("List");
            return View(prod);
        }
        [HttpPost]
        public ActionResult AddToCart(CAddToCartViewModel vModel)
        {
            dbDemoContext db = new dbDemoContext();
            TProduct prod = db.TProducts.FirstOrDefault(t => t.FId == vModel.txtFid);
            if (prod == null)
                return RedirectToAction("List");


            string jsonCart = "";
            List<CShoppingCartItem> list = null;
            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_已經購買的_商品們_列表))
                list = new List<CShoppingCartItem>();
            else
            {
                jsonCart = HttpContext.Session.GetString(CDictionary.SK_已經購買的_商品們_列表);
                list = JsonSerializer.Deserialize<List<CShoppingCartItem>>(jsonCart);
            }
            CShoppingCartItem item = new CShoppingCartItem()
            {
                count = vModel.txtCount,
                price = (decimal)prod.FPrice,
                productId = vModel.txtFid,
                product = prod
            };
            list.Add(item);
            jsonCart = JsonSerializer.Serialize(list);
            HttpContext.Session.SetString(
                CDictionary.SK_已經購買的_商品們_列表, jsonCart);

            return RedirectToAction("List");
        }

    }
}

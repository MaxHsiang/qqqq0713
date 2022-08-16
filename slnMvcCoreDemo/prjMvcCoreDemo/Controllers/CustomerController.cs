using Microsoft.AspNetCore.Mvc;
using prjMvcCoreDemo.Models;
using prjMvcCoreDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjMvcCoreDemo.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult List(CKeywordViewModel vModel)
        {
            dbDemoContext db = new dbDemoContext();
            IEnumerable<TCustomer> datas = null;
            if (string.IsNullOrEmpty(vModel.txtKeyword))
            {
                datas = from t in db.TCustomers
                        select t;
            }
            else
            { 
                datas = db.TCustomers.Where(t => t.FName.Contains(vModel.txtKeyword) ||
                    t.FPhone.Contains(vModel.txtKeyword) ||
                    t.FEmail.Contains(vModel.txtKeyword) ||
                    t.FAddress.Contains(vModel.txtKeyword));
            }
            return View(datas);
        }
        public IActionResult Create ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(TCustomer p)
        {
            dbDemoContext db = new dbDemoContext();
            db.TCustomers.Add(p);
            db.SaveChanges();
            return RedirectToAction("List");
        }
        public IActionResult Edit(int? id)
        {
            dbDemoContext db = new dbDemoContext();
            TCustomer cust = db.TCustomers.FirstOrDefault(c => c.FId == id);
            if (cust == null) 
                return RedirectToAction("List");
            return View(cust);
        }
        [HttpPost]
        public IActionResult Edit(TCustomer p)
        {
            dbDemoContext db = new dbDemoContext();
            TCustomer cust = db.TCustomers.FirstOrDefault(c => c.FId == p.FId);
            if (cust != null)
            {
                cust.FName = p.FName;
                cust.FPhone = p.FPhone;
                cust.FEmail = p.FEmail;
                cust.FAddress = p.FAddress;
                cust.FPassword = p.FPassword;
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }
        public IActionResult Delete(int? id)
        {
            dbDemoContext db = new dbDemoContext();
            TCustomer cust = db.TCustomers.FirstOrDefault(c => c.FId == id);
            if (cust != null)
            {
                db.TCustomers.Remove(cust);
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }

    }
}

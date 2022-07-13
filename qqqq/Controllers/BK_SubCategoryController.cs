using Microsoft.AspNetCore.Mvc;
using qqqq.ViewModels;
using qqqq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace qqqq.Controllers
{
    public class BK_SubCategoryController : Controller
    {
        public IActionResult sbpetList()
        {

            我救浪Context db = new 我救浪Context();
            var datas = from S in db.SubCategories
                        where S.Category.IsPet == true && S.Category.CategoryName != "不限"
                        select S;
            List<CSubCategoryPet> list = new List<CSubCategoryPet>();
            foreach (SubCategory S in datas)
            {
                CSubCategoryPet sub = new CSubCategoryPet();
                sub.SubCategory = S;
                list.Add(sub);
            }
            return View(list);
        }


        //新增類別
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(SubCategory sub)
        {
            我救浪Context db = new 我救浪Context();

            db.SubCategories.Add(sub);
            db.SaveChanges();
            return RedirectToAction("sbpetList");
        }

        //刪除類別
        public IActionResult Delete(int? id)
        {
            我救浪Context db = new 我救浪Context();
            SubCategory sub = db.SubCategories.FirstOrDefault(S => S.SubCategoryId == id);
            if (sub != null)
            {
                db.SubCategories.Remove(sub);
                db.SaveChanges();
            }
            return RedirectToAction("sbpetList");
        }


        //修改類別
        public IActionResult Edit(int? id)
        {
            我救浪Context db = new 我救浪Context();
            SubCategory sub = db.SubCategories.FirstOrDefault(S => S.SubCategoryId == id);
            if (sub == null)
                return RedirectToAction("sbpetList");
            return View(new CSubCategoryPet(sub));
        }
        [HttpPost]
        public IActionResult Edit(SubCategory sub)
        {
            我救浪Context db = new 我救浪Context();
            SubCategory subCategory = db.SubCategories.FirstOrDefault(S => S.SubCategoryId == sub.SubCategoryId);
            if (subCategory != null)
            {
                subCategory.SubCategoryName = sub.SubCategoryName;
                db.SaveChanges();
            }
            return RedirectToAction("sbpetList");
        }

    }
}

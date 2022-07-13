using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using qqqq.Models;
using qqqq.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace qqqq.Controllers
{
    public class BK_VolunteerController : Controller
    {
        private IWebHostEnvironment _environment;
        public BK_VolunteerController(IWebHostEnvironment p)
        {
            _environment = p;
        }
        我救浪Context db = new 我救浪Context();
        public IActionResult BK_VolunteerActivity()
        {
            var a = db.Vactivities.Select(n => n);
            List<BK_VActivityViewModel> list = new List<BK_VActivityViewModel>();
            foreach (Vactivity i in a)
            {
                BK_VActivityViewModel Vm = new BK_VActivityViewModel();
                Vm.vactivity = i;
                list.Add(Vm);
            }
            foreach (BK_VActivityViewModel i in list)
            {
                var b = db.VactivityCategories.Where(x => x.ActivityCategoryId == i.ActivityCategoryId).Select(y => y.CategoryName).FirstOrDefault();
                i.ActivityCategoryName = b;
            }
            return View(list);
        }
        public IActionResult getCategoryName()
        {
            var cateList = db.VactivityCategories.Select(x => x.CategoryName);
            return Json(cateList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(BK_VActivityViewModel model)
        {
            string picName = "Demo.jpg";
            if (model.photo != null)
            {
                picName = Guid.NewGuid().ToString() + ".jpg";
                model.photo.CopyTo(new FileStream(_environment.WebRootPath + "/img/volunteer/" + picName, FileMode.Create));
            }
            Vactivity activity = new Vactivity()
            {
                ActivityId = 0,
                Title = model.Title,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                ActivityCategoryId = db.VactivityCategories.Where(x => x.CategoryName == model.ActivityCategoryName).Select(y => y.ActivityCategoryId).FirstOrDefault(),
                PeopleInNeed = model.PeopleInNeed,
                ActivityPhoto = picName,
                Description = model.Description
            };

            db.Vactivities.Add(activity);
            db.SaveChanges();
            return RedirectToAction("BK_VolunteerActivity");
        }
        public IActionResult Delete(int? id)
        {
            var a = db.Vactivities.FirstOrDefault(x => x.ActivityId == id);
            if (a != null)
            {
                db.Vactivities.Remove(a);
                db.SaveChanges();
            }
            return RedirectToAction("BK_VolunteerActivity");
        }
        public IActionResult Edit(int? id)
        {
            var a = db.Vactivities.FirstOrDefault(x => x.ActivityId == id);
            if (a == null)
            {
                return RedirectToAction("BK_VolunteerActivity");
            }
            BK_VActivityViewModel model = new BK_VActivityViewModel()
            {
                vactivity = a,
                ActivityCategoryName = db.VactivityCategories.Where(x => x.ActivityCategoryId == a.ActivityCategoryId).Select(y => y.CategoryName).FirstOrDefault()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(BK_VActivityViewModel model)
        {

            Vactivity a = db.Vactivities.FirstOrDefault(x => x.ActivityId == model.ActivityId);
            if (a != null)
            {
                if (model.photo != null)
                {
                    string picName = Guid.NewGuid().ToString() + ".jpg";
                    model.photo.CopyTo(new FileStream(_environment.WebRootPath + "/img/volunteer/" + picName, FileMode.Create));
                    a.ActivityPhoto = picName;
                }
                a.ActivityId = model.ActivityId;
                a.Title = model.Title;
                a.StartDate = model.StartDate;
                a.EndDate = model.EndDate;
                a.ActivityCategoryId = db.VactivityCategories.Where(x => x.CategoryName == model.ActivityCategoryName).Select(y => y.ActivityCategoryId).FirstOrDefault();

                System.Diagnostics.Debug.WriteLine(model.ActivityCategoryName);
                a.PeopleInNeed = model.PeopleInNeed;
                a.Description = model.Description;
            }
            db.SaveChanges();
            return RedirectToAction("BK_VolunteerActivity");
        }
    }
}


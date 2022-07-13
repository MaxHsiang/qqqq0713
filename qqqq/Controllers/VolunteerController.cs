
//using final_test.Models;
using final_test.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Pet.ViewModels;
using qqqq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final_test.Controllers
{
    public class VolunteerController : Controller
    {

        我救浪Context db = new 我救浪Context();
        List<VActivityViewModel> list = new List<VActivityViewModel>();
        public IActionResult Index()
        {
            IEnumerable<Vactivity> a = db.Vactivities.Select(x => x);
            foreach (Vactivity i in a)
            {
                VActivityViewModel v = new VActivityViewModel()
                {
                    ActivityID = i.ActivityId,
                    StartDate = i.StartDate,
                    EndDate = i.EndDate,
                    Title = i.Title,
                    PeopleInNeed = i.PeopleInNeed,
                    ActivityCategoryID = i.ActivityCategoryId,
                    ActivityPhoto = i.ActivityPhoto,
                };
                list.Add(v);
            }
            foreach (VActivityViewModel i in list)
            {
                string b = db.VactivityCategories.Where(x => x.ActivityCategoryId == i.ActivityCategoryID).Select(y => y.CategoryName).FirstOrDefault();
                i.ActivityCategoryName = b;
            }
            return View(list);
        }
        public IActionResult activitypage()
        {
            return View();
        }
        public IActionResult Info(int? id)
        {
            int ID = id.Value;
            var a = db.Vactivities.Where(x => x.ActivityId == id).Select(y => y).FirstOrDefault();
            VActivityViewModel v = new VActivityViewModel()
            {
                ActivityID = a.ActivityId,
                StartDate = a.StartDate,
                EndDate = a.EndDate,
                Title = a.Title,
                PeopleInNeed = a.PeopleInNeed,
                ActivityCategoryID = a.ActivityCategoryId,
                ActivityPhoto = a.ActivityPhoto,
                ActivityCategoryName = db.VactivityCategories.Where(x => x.ActivityCategoryId == a.ActivityCategoryId).Select(y => y.CategoryName).FirstOrDefault()
            };
            return View(v);
        }
        public IActionResult SignUp(int? id)
        {
            int ID = id.Value;
            var a = db.Vactivities.Where(x => x.ActivityId == id).Select(y => y).FirstOrDefault();
            VActivityViewModel v = new VActivityViewModel()
            {
                ActivityID = a.ActivityId,
                StartDate = a.StartDate,
                EndDate = a.EndDate,
                Title = a.Title,
                PeopleInNeed = a.PeopleInNeed,
                ActivityCategoryID = a.ActivityCategoryId,
                ActivityPhoto = a.ActivityPhoto,
                Description = a.Description,
                ActivityCategoryName = db.VactivityCategories.Where(x => x.ActivityCategoryId == a.ActivityCategoryId).Select(y => y.CategoryName).FirstOrDefault()
            };
            //System.Diagnostics.Debug.WriteLine(a.ActivityCategoryName.ToString());
            return View(v);
        }
    }
}

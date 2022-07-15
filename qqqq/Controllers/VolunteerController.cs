using final_test.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
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
            return View();
        }
        public IActionResult loadCheckBox()
        {
            var a = db.VactivityCategories.Select(x => x).ToList();
            return Json(a);
        }
        [HttpGet("{id}")]
        public string GetCategoryName(int? id)  
        {
            return db.VactivityCategories.Where(x => x.ActivityCategoryId == id).Select(y => y.CategoryName).FirstOrDefault().ToString();
        }
        public IActionResult activitypage()
        {
            return View();
        }
        public IActionResult Info(int? id)
        {
            int ID = id.Value;
            var a = db.Vactivities.Where(x => x.ActivityId == id).Select(y => y).FirstOrDefault();
            VActivityViewModel v = new VActivityViewModel();
            v.vactivity = a;
            v.ActivityCategoryName = GetCategoryName(a.ActivityCategoryId);
            return View(v);
        }
        public IActionResult SignUp(int? id)
        {
            int ID = id.Value;
            var a = db.Vactivities.Where(x => x.ActivityId == id).Select(y => y).FirstOrDefault();
            VActivityViewModel v = new VActivityViewModel();
            v.vactivity = a;
            v.ActivityCategoryName = GetCategoryName(a.ActivityCategoryId);
            //System.Diagnostics.Debug.WriteLine(a.ActivityCategoryName.ToString());
            return View(v);
        }
        public IActionResult loadList(int[] intarr,DateTime date,string keyString)
        {
            //foreach(int i in arr)
            //{
            //    System.Diagnostics.Debug.WriteLine(i);
            //}
            //return Json(arr);
            list.Clear();
            IEnumerable<Vactivity> a = db.Vactivities.Select(x => x).ToList();
            List<VActivityViewModel> resultList = new List<VActivityViewModel>();
            foreach (Vactivity j in a)
            {
                VActivityViewModel v = new VActivityViewModel()
                {
                    vactivity = j,
                    ActivityCategoryName = GetCategoryName(j.ActivityCategoryId)
                };
                list.Add(v);
            }
            //
            if (intarr.Length != 0)
            {
                foreach(int i in intarr)
                {
                    foreach(VActivityViewModel j in list)
                    {
                        if(j.ActivityCategoryID == i)
                        {
                            resultList.Add(j);
                        }
                    }
                }
            }
            //
            int year = date.Year, month = date.Month, day = date.Day;

            System.Diagnostics.Debug.WriteLine(year ); //1
            System.Diagnostics.Debug.WriteLine(month);
            if(year != 1)
            {
               
            }




            System.Diagnostics.Debug.WriteLine(keyString);  //



























            //if (intarr.Length != 0)
            //{
            //    foreach (int i in intarr)
            //    {
                    
            //        IEnumerable<Vactivity> a = db.Vactivities.Where(y => y.ActivityCategoryId == i).Select(x => x).ToList();
            //        foreach (Vactivity j in a)
            //        {
            //            VActivityViewModel v = new VActivityViewModel()
            //            {
            //                vactivity = j,
            //                ActivityCategoryName = GetCategoryName(j.ActivityCategoryId)
            //            };
            //            list.Add(v);
            //        }
            //    }
            //}
            //else
            //{
            //    IEnumerable<Vactivity> a = db.Vactivities.Select(x => x).ToList();
            //    foreach (Vactivity j in a)
            //    {
            //        VActivityViewModel v = new VActivityViewModel()
            //        {
            //            vactivity = j,
            //            ActivityCategoryName = GetCategoryName(j.ActivityCategoryId)
            //        };
            //        list.Add(v);
            //    }
            //}
            if(resultList.Count == 0)
            {
                return Json(list);
            }
            return Json(resultList);
        }
    }
}

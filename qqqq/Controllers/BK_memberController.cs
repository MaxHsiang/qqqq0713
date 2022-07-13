using Microsoft.AspNetCore.Mvc;
using Pet.ViewModels;
using qqqq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace qqqq.Controllers
{
    public class BK_memberController : Controller
    {
        public IActionResult memList(CMemberView vModel)
        {
            //我救浪Context db = new 我救浪Context();
            //IEnumerable<Member> datas = null;
            //if(string.IsNullOrEmpty(vModel.txtKeyword))
            //{
            //    datas = from m in db.Members
            //            select m;
            //}
            //else
            //{
            //    datas = db.Members.Where(m => m.Name.Contains(vModel.txtKeyword));
            //}
            //ViewBag.keyword = vModel.txtKeyword;
            //return View(datas);



            我救浪Context db = new 我救浪Context();
            var datas = from m in db.Members
                        select m;
            List<CMemberView> list = new List<CMemberView>();
            foreach (Member m in datas)
            {
                CMemberView v = new CMemberView();
                v.Member = m;
                //v.MemberNewBirthDate =(string)m.BirthdayDate.ToString();
                list.Add(v); 
            }
            return View(list);
        }

        //新增會員
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Member m)
        {
            我救浪Context db = new 我救浪Context();


            db.Members.Add(m);
            db.SaveChanges();
            return RedirectToAction("memList");
        }


        //刪除會員
        public IActionResult Delete(int? id)
        {
            我救浪Context db = new 我救浪Context();
            Member mem = db.Members.FirstOrDefault(m => m.MemberId == id);
            if (mem != null)
            {
                db.Members.Remove(mem);
                db.SaveChanges();
            }
            return RedirectToAction("memList");
        }


        //修改會員
        public IActionResult Edit(int? id)
        {
            我救浪Context db = new 我救浪Context();
            Member mem = db.Members.FirstOrDefault(m => m.MemberId == id);
            if (mem == null)
                return RedirectToAction("memList");
            return View(new CMemberView(mem));
        }
        [HttpPost]
        public IActionResult Edit(Member mb)
        {
            我救浪Context db = new 我救浪Context();
            Member mem = db.Members.FirstOrDefault(m => m.MemberId == mb.MemberId);
            if (mem != null)
            {
                mem.Name = mb.Name;
                mem.Password = mb.Password;
                mem.Address = mb.Address;
                mem.BirthdayDate = mb.BirthdayDate;
                mem.Email = mb.Email;
                mem.MemberPhone = mb.MemberPhone;
                db.SaveChanges();

            }
            return RedirectToAction("memList");
        }
    }
}

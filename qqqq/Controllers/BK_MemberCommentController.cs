using Microsoft.AspNetCore.Mvc;
using qqqq.Models;
using qqqq.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace qqqq.Controllers
{
    public class BK_MemberCommentController : Controller
    {
        我救浪Context db = new 我救浪Context();
        public IActionResult Index()
        {
            var a = db.MemberComments.Select(x => x);
            List<BK_MemberCommentViewModel> list = new List<BK_MemberCommentViewModel>();
            foreach (var i in a)
            {
                BK_MemberCommentViewModel vm = new BK_MemberCommentViewModel();
                vm.membercomment = i;
                list.Add(vm);
            }
            foreach (var i in list)
            {
                i.ProductName = db.Products.Where(x => x.ProductId == i.ProductId).Select(y => y.ProductName).FirstOrDefault();
            }
            return View(list);
        }
    }
}

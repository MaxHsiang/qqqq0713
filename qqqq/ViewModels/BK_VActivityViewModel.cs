using Microsoft.AspNetCore.Http;
using qqqq.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace qqqq.ViewModels
{
    public class BK_VActivityViewModel
    {
        private Vactivity _vactivity;
        public BK_VActivityViewModel()
        {
            _vactivity = new Vactivity();
        }
        public Vactivity vactivity
        {
            get { return _vactivity; }
            set { _vactivity = value; }
        }
        public int ActivityId { get { return _vactivity.ActivityId; } set { _vactivity.ActivityId = value; } }
        [DisplayName("活動標題")]
        public string Title { get { return _vactivity.Title; } set { _vactivity.Title = value; } }
        [DisplayName("開始日期")]
        public string StartDate { get { return _vactivity.StartDate; } set { _vactivity.StartDate = value; } }
        [DisplayName("結束日期")]
        public string EndDate { get { return _vactivity.EndDate; } set { _vactivity.EndDate = value; } }
        public int? ActivityCategoryId { get { return _vactivity.ActivityCategoryId; } set { _vactivity.ActivityCategoryId = value; } }
        [DisplayName("需求人數")]
        public int? PeopleInNeed { get { return _vactivity.PeopleInNeed; } set { _vactivity.PeopleInNeed = value; } }
        [DisplayName("照片")]
        public string ActivityPhoto { get { return _vactivity.ActivityPhoto; } set { _vactivity.ActivityPhoto = value; } }
        [DisplayName("描述")]
        public string Description { get { return _vactivity.Description; } set { _vactivity.Description = value; } }
        [DisplayName("類別")]
        public string ActivityCategoryName { get; set; }
        public virtual VactivityCategory ActivityCategory { get; set; }
        public virtual ICollection<Volunteer> Volunteers { get; set; }

        public IFormFile photo { get; set; }
    }
}

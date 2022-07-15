using qqqq.Models;
using Pet.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace final_test.ViewModels
{
    public class VActivityViewModel
    {
        private Vactivity _vactivity;

        private CMemberView _cMemberView;
        public VActivityViewModel()
        {
            _cMemberView = new CMemberView();
            _vactivity = new Vactivity();
        }
        public Vactivity vactivity { get { return _vactivity; } set { _vactivity = value; } }
        public int ActivityID { get { return _vactivity.ActivityId; } set { _vactivity.ActivityId = value; } }
        public string Title { get { return _vactivity.Title; } set { _vactivity.Title = value; } }
        public string StartDate { get { return _vactivity.StartDate; } set { _vactivity.StartDate = value; } }
        public string EndDate { get { return _vactivity.EndDate; } set { _vactivity.EndDate = value; } }
        public int? ActivityCategoryID { get { return _vactivity.ActivityCategoryId; } set { _vactivity.ActivityCategoryId = value; } }
        public int? PeopleInNeed { get { return _vactivity.PeopleInNeed; } set { _vactivity.PeopleInNeed = value; } }
        public string ActivityPhoto { get { return _vactivity.ActivityPhoto; } set { _vactivity.ActivityPhoto = value; } }
        public string ActivityCategoryName { get; set; }
        public string MemberName { get { return "劉俊賢"; } set { _cMemberView.MemberName = value; } }
        public string MemberPhone { get { return "0941041041"; } set { _cMemberView.MemberPhone = value; } }
        public string MemberEmail { get { return "041041@gmail.com"; } set { _cMemberView.MemberEmail = value; } }
        public string MemberAddress { get { return "臺中市潭子區得福街13號"; } set { _cMemberView.MemberAddress = value; } }
        public string Description { get { return _vactivity.Description; } set { _vactivity.Description = value; } }

    }
}

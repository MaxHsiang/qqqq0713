using qqqq.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Pet.ViewModels
{
    public class CMemberView
    {
        public Member Member;
        public CMemberView()
        {
            Member = new Member();
        }
        public int MemberID { get { return Member.MemberId; } set { Member.MemberId = value; } }
        public int MemberId { get { return Member.MemberId; } set { Member.MemberId = value; } }
        [DisplayName("會員名稱")]
        public string MemberName { get { return Member.Name; }set { Member.Name = value; } }
        [DisplayName("密碼")]
        public string MemberPassword { get { return Member.Password; } set { Member.Password = value; } }
        [DisplayName("手機")]
        public string MemberPhone { get { return Member.MemberPhone; } set { Member.MemberPhone = value; } }
        [DisplayName("地址")]
        public string MemberAddress { get { return Member.Address; } set { Member.Address = value; } }
        public int MemberCityID { get { return (int)Member.CityId; } set { Member.CityId = value; } }
        [DisplayName("城市")]
        public string MemberCityName { get { return Member.City.CityName; }}
        [DisplayName("生日")]
        public DateTime MemberBirthDate { get { return (DateTime)Member.BirthdayDate; } set { Member.BirthdayDate = value; } }
        [DisplayName("Email")]
        public string MemberEmail { get { return Member.Email; } set { Member.Email = value; } }

        /// <summary>
        /// ////////////////////
        /// </summary>
        /// 
        [DisplayName("生日")]
        public string MemberNewBirthDate { get { return ((DateTime)Member.BirthdayDate).ToString("yyyy/MM/dd"); } }

        [DisplayName("頭貼")]
        public string MemberPhoto { get { return Member.Photo; } set { Member.Photo = value; } }

        public CMemberView(Member member)
        {
            Member = member;
        }
        //看資料庫新增的欄位取什麼
        //[DisplayName("志工時數")]
        //public string Member志工時數 { get { return Member.志工時數; } set { Member.志工時數= value; } }



    }
}
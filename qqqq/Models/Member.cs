using System;
using System.Collections.Generic;

#nullable disable

namespace qqqq.Models
{
    public partial class Member
    {
        public Member()
        {
            MemberComments = new HashSet<MemberComment>();
            MyFavorites = new HashSet<MyFavorite>();
            Orders = new HashSet<Order>();
            Volunteers = new HashSet<Volunteer>();
        }

        public int MemberId { get; set; }
        public string MemberPhone { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int? CityId { get; set; }
        public DateTime? BirthdayDate { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public int? HgenderId { get; set; }
        public int? VolunteerHour { get; set; }

        public virtual City City { get; set; }
        public virtual Hgender Hgender { get; set; }
        public virtual MemberWish MemberWish { get; set; }
        public virtual ICollection<MemberComment> MemberComments { get; set; }
        public virtual ICollection<MyFavorite> MyFavorites { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Volunteer> Volunteers { get; set; }
    }
}

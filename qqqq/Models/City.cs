using System;
using System.Collections.Generic;

#nullable disable

namespace qqqq.Models
{
    public partial class City
    {
        public City()
        {
            MemberWishes = new HashSet<MemberWish>();
            Members = new HashSet<Member>();
            PetDetails = new HashSet<PetDetail>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }

        public virtual ICollection<MemberWish> MemberWishes { get; set; }
        public virtual ICollection<Member> Members { get; set; }
        public virtual ICollection<PetDetail> PetDetails { get; set; }
    }
}

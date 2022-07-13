using System;
using System.Collections.Generic;

#nullable disable

namespace qqqq.Models
{
    public partial class Gender
    {
        public Gender()
        {
            MemberWishes = new HashSet<MemberWish>();
            PetDetails = new HashSet<PetDetail>();
        }

        public int GenderId { get; set; }
        public string GenderType { get; set; }

        public virtual ICollection<MemberWish> MemberWishes { get; set; }
        public virtual ICollection<PetDetail> PetDetails { get; set; }
    }
}

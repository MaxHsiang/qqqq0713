using System;
using System.Collections.Generic;

#nullable disable

namespace qqqq.Models
{
    public partial class Age
    {
        public Age()
        {
            MemberWishes = new HashSet<MemberWish>();
            PetDetails = new HashSet<PetDetail>();
        }

        public int AgeId { get; set; }
        public string AgeType { get; set; }

        public virtual ICollection<MemberWish> MemberWishes { get; set; }
        public virtual ICollection<PetDetail> PetDetails { get; set; }
    }
}

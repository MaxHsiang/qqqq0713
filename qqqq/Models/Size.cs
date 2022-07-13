using System;
using System.Collections.Generic;

#nullable disable

namespace qqqq.Models
{
    public partial class Size
    {
        public Size()
        {
            MemberWishes = new HashSet<MemberWish>();
            PetDetails = new HashSet<PetDetail>();
        }

        public int SizeId { get; set; }
        public string SizeType { get; set; }

        public virtual ICollection<MemberWish> MemberWishes { get; set; }
        public virtual ICollection<PetDetail> PetDetails { get; set; }
    }
}

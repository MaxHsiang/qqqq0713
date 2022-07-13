using System;
using System.Collections.Generic;

#nullable disable

namespace qqqq.Models
{
    public partial class MemberWishColor
    {
        public int MemberWishColorId { get; set; }
        public int? MemberId { get; set; }
        public int? ColorId { get; set; }

        public virtual Color Color { get; set; }
        public virtual MemberWish Member { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace qqqq.Models
{
    public partial class MemberWish
    {
        public MemberWish()
        {
            MemberWishColors = new HashSet<MemberWishColor>();
        }

        public int MemberId { get; set; }
        public int? CityId { get; set; }
        public decimal? YearCost { get; set; }
        public int? Space { get; set; }
        public int? AgeId { get; set; }
        public int? AccompanyTimeWeek { get; set; }
        public int? LigationId { get; set; }
        public int SubCategoryId { get; set; }
        public int? GenderId { get; set; }
        public int? SizeId { get; set; }
        public int? CategoryId { get; set; }

        public virtual Age Age { get; set; }
        public virtual Category Category { get; set; }
        public virtual City City { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Ligation Ligation { get; set; }
        public virtual Member Member { get; set; }
        public virtual Size Size { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public virtual ICollection<MemberWishColor> MemberWishColors { get; set; }
    }
}

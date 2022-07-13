using System;
using System.Collections.Generic;

#nullable disable

namespace qqqq.Models
{
    public partial class SubCategory
    {
        public SubCategory()
        {
            MemberWishes = new HashSet<MemberWish>();
            Products = new HashSet<Product>();
        }

        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<MemberWish> MemberWishes { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace qqqq.Models
{
    public partial class Category
    {
        public Category()
        {
            MemberWishes = new HashSet<MemberWish>();
            SubCategories = new HashSet<SubCategory>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool? IsPet { get; set; }
        public int? ParentCategory { get; set; }

        public virtual ICollection<MemberWish> MemberWishes { get; set; }
        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}

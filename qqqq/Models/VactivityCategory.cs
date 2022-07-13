using System;
using System.Collections.Generic;

#nullable disable

namespace qqqq.Models
{
    public partial class VactivityCategory
    {
        public VactivityCategory()
        {
            Vactivities = new HashSet<Vactivity>();
        }

        public int ActivityCategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Vactivity> Vactivities { get; set; }
    }
}

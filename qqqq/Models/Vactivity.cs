using System;
using System.Collections.Generic;

#nullable disable

namespace qqqq.Models
{
    public partial class Vactivity
    {
        public Vactivity()
        {
            Volunteers = new HashSet<Volunteer>();
        }

        public int ActivityId { get; set; }
        public string Title { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int? ActivityCategoryId { get; set; }
        public int? PeopleInNeed { get; set; }
        public string ActivityPhoto { get; set; }
        public string Description { get; set; }

        public virtual VactivityCategory ActivityCategory { get; set; }
        public virtual ICollection<Volunteer> Volunteers { get; set; }
    }
}

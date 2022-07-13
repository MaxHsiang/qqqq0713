using System;
using System.Collections.Generic;

#nullable disable

namespace qqqq.Models
{
    public partial class VallowTime
    {
        public VallowTime()
        {
            Volunteers = new HashSet<Volunteer>();
        }

        public int AllowTimeId { get; set; }
        public string TimeRange { get; set; }

        public virtual ICollection<Volunteer> Volunteers { get; set; }
    }
}

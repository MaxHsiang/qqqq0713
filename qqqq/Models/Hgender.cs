using System;
using System.Collections.Generic;

#nullable disable

namespace qqqq.Models
{
    public partial class Hgender
    {
        public Hgender()
        {
            Members = new HashSet<Member>();
        }

        public int HgenderId { get; set; }
        public string GenderType { get; set; }

        public virtual ICollection<Member> Members { get; set; }
    }
}

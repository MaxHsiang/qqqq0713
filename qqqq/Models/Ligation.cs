using System;
using System.Collections.Generic;

#nullable disable

namespace qqqq.Models
{
    public partial class Ligation
    {
        public Ligation()
        {
            MemberWishes = new HashSet<MemberWish>();
            PetDetails = new HashSet<PetDetail>();
        }

        public int LigationId { get; set; }
        public string LigationType { get; set; }

        public virtual ICollection<MemberWish> MemberWishes { get; set; }
        public virtual ICollection<PetDetail> PetDetails { get; set; }
    }
}

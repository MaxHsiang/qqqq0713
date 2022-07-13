using System;
using System.Collections.Generic;

#nullable disable

namespace qqqq.Models
{
    public partial class MyFavorite
    {
        public int MyFavorite1 { get; set; }
        public int MemberId { get; set; }
        public int ProductId { get; set; }

        public virtual Member Member { get; set; }
        public virtual Product Product { get; set; }
    }
}

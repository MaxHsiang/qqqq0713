using System;
using System.Collections.Generic;

#nullable disable

namespace qqqq.Models
{
    public partial class MemberComment
    {
        public int CommentId { get; set; }
        public int? ProductId { get; set; }
        public int? MemberId { get; set; }
        public int? Grade { get; set; }
        public string Description { get; set; }
        public DateTime? CommentDate { get; set; }

        public virtual Member Member { get; set; }
        public virtual Product Product { get; set; }
    }
}

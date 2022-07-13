using qqqq.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace qqqq.ViewModels
{
    public class BK_MemberCommentViewModel
    {
        private MemberComment _membercomment;
        public BK_MemberCommentViewModel()
        {
            _membercomment = new MemberComment();
        }
        public MemberComment membercomment
        {
            get { return _membercomment; }
            set { _membercomment = value; }
        }
        public int CommentId { get { return _membercomment.CommentId; } set { _membercomment.CommentId = value; } }
        public int? ProductId { get { return _membercomment.ProductId; } set { _membercomment.ProductId = value; } }
        [DisplayName("會員ID")]
        public int? MemberId { get { return _membercomment.MemberId; } set { _membercomment.MemberId = value; } }
        [DisplayName("評分")]
        public int? Grade { get { return _membercomment.Grade; } set { _membercomment.Grade = value; } }
        [DisplayName("評論")]
        public string Description { get { return _membercomment.Description; } set { _membercomment.Description = value; } }
        [DisplayName("評論日期")]
        public DateTime? CommentDate { get { return _membercomment.CommentDate; } set { _membercomment.CommentDate = value; } }
        [DisplayName("產品名稱")]
        public string ProductName { get; set; }
        public virtual Member Member { get; set; }
        public virtual Product Product { get; set; }
    }
}

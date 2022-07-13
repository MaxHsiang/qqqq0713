using System;
using System.Collections.Generic;

#nullable disable

namespace qqqq.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public int? MemberId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string SendAddress { get; set; }
        public int? OrderStatusId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Member Member { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}

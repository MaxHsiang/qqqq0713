using System;
using System.Collections.Generic;

#nullable disable

namespace qqqq.Models
{
    public partial class OrderStatus
    {
        public OrderStatus()
        {
            Orders = new HashSet<Order>();
        }

        public int OrderStatusId { get; set; }
        public string StatusType { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}

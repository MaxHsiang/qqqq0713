using System;
using System.Collections.Generic;

#nullable disable

namespace qqqq.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            Products = new HashSet<Product>();
        }

        public int SupplierId { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public int? EmployeeId { get; set; }
        public string Description { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}

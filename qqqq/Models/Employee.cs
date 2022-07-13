using System;
using System.Collections.Generic;

#nullable disable

namespace qqqq.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Orders = new HashSet<Order>();
            Suppliers = new HashSet<Supplier>();
        }

        public int EmpoyeeId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}

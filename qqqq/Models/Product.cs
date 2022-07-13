using System;
using System.Collections.Generic;

#nullable disable

namespace qqqq.Models
{
    public partial class Product
    {
        public Product()
        {
            MemberComments = new HashSet<MemberComment>();
            MyFavorites = new HashSet<MyFavorite>();
            OrderDetails = new HashSet<OrderDetail>();
            Photos = new HashSet<Photo>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int SubCategoryId { get; set; }
        public decimal? Price { get; set; }
        public int? SupplierId { get; set; }
        public bool? IsPet { get; set; }
        public string Description { get; set; }
        public int? UnitsInStock { get; set; }
        public bool? Continued { get; set; }
        public decimal? Cost { get; set; }

        public virtual SubCategory SubCategory { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual PetDetail PetDetail { get; set; }
        public virtual ICollection<MemberComment> MemberComments { get; set; }
        public virtual ICollection<MyFavorite> MyFavorites { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
    }
}

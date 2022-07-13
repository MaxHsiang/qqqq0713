using qqqq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace qqqq.ViewModels
{
    public class CProductShow
    {
        public CProductShow() {
            _prod = new Product();
            Photos = new List<Photo>();
            
        }
        private Product _prod;
        public Product product
        {
            get { return _prod; }
            set
            {
                _prod = value;
            }
        }

        public int ProductId { get { return _prod.ProductId; } set { _prod.ProductId = value; } }
        public string ProductName { get { return _prod.ProductName; } set { _prod.ProductName = value; } }
        public int SubCategoryId { get { return _prod.SubCategoryId; } set { _prod.SubCategoryId = value; } }
        public decimal? Price { get { return _prod.Price; } set { _prod.Price = value; } }
        public int? SupplierId { get { return _prod.SupplierId; } set { _prod.SupplierId = value; } }
        public bool? IsPet { get { return _prod.IsPet; } set { _prod.IsPet = value; } }
        public string Description { get { return _prod.Description; } set { _prod.Description = value; } }
        public int? UnitsInStock { get { return _prod.UnitsInStock; } set { _prod.UnitsInStock = value; } }
        public bool? Continued { get { return _prod.Continued; } set { _prod.Continued = value; } }
        public decimal? Cost { get { return _prod.Cost; } set { _prod.Cost = value; } }
        public  List<Photo> Photos { get; set; }
        public string SubCategoryName { get { return product.SubCategory.SubCategoryName; }  }
        public string CategoryName { get { return product.SubCategory.Category.CategoryName; } }
        public string SupplierName { get { return product.Supplier.Name; } }
    }
}

using qqqq.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace prjHomeLess.ViewModel
{
    public class CPet
    {
        public Product _prod;
        public CPet()
        {
            _prod = new Product();
        }
        public CPet(Product product)
        {
            Product = product;
        }
        


        public Product Product
        {
            get { return _prod; }
            set { _prod = value; }
        }


        [DisplayName("序號")]
        public int ProductId
        {
            get { return _prod.ProductId; }
            set { _prod.ProductId = value; }
        }
        [DisplayName("名稱")]
        public string ProductName
        {
            get { return _prod.ProductName; }
            set { _prod.ProductName = value; }
        }
        public int SubCategoryId { get { return _prod.SubCategoryId; } set { _prod.SubCategoryId = value; } }
        public decimal? Price { get { return _prod.Price; } set { _prod.Price = value; } }
        public int? SupplierId { get { return _prod.SupplierId; } set { _prod.SupplierId = value; } }
        public bool? IsPet { get { return _prod.IsPet; } set { _prod.IsPet = value; } }



        [DisplayName("描述")]
        public string Description
        {
            get { return _prod.Description; }
            set { _prod.Description = value; }
        }
        public int? UnitsInStock { get { return _prod.UnitsInStock; } set { _prod.UnitsInStock = value; } }

        [DisplayName("領養狀態")]
        public bool? Continued
        {
            get { return _prod.Continued; }
            set { _prod.Continued = value; }
        }
        public decimal? Cost { get { return _prod.Cost; } set { _prod.Cost = value; } }

        [DisplayName("品種")]
        public string SubCategoryName
        {
            get { return _prod.SubCategory.SubCategoryName; }
            set { _prod.SubCategory.SubCategoryName = value; }
        }
        [DisplayName("類別")]
        public string CategoryName
        {
            get { return _prod.SubCategory.Category.CategoryName; }
            set { _prod.SubCategory.Category.CategoryName = value; }
        }
    }
}

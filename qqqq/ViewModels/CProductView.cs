using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using qqqq.Models;


namespace Pet.ViewModels
{
    public class CProductView
    {
        private 我救浪Context db = new 我救浪Context();
        public Product Product;
        public CProductView()
        {
            Product=new Product();
        }
        public CProductView(Product p)
        {
            Product = p;
            //SubCategoryName = (from s in db.SubCategories where s.SubCategoryId == p.SubCategoryId select s).FirstOrDefault().SubCategoryName;
            //SupplierName = db.Suppliers.FirstOrDefault(s => s.SupplierId == p.SupplierId).Name;
            //var q = db.Photos.Where(ph => ph.ProductId == p.ProductId);
            //foreach (var ph in q) PictureNames.Add(ph.PictureName);
            //var q = p.Photos.Select(ph=>ph).ToList();
            //foreach(var ph in q)
            //{
            //    PictureNames.Add(ph.PictureName);
            //}
        }
        static public List<CProductView> CProductViews(List<Product> list_product)
        {
            List<CProductView> list=new List<CProductView>();
            foreach(var p in list_product)
            {
                CProductView cProductView = new CProductView(p);
                list.Add(cProductView);
            }
            return list;
        }
        public int ProductId { get { return this.Product.ProductId; }}
        [DisplayName("產品名稱")]
        public string ProductName { get { return this.Product.ProductName; } set { this.Product.ProductName = value; } }
        public int SubCategoryId { get { return this.Product.SubCategoryId; } set { this.Product.SubCategoryId = value; } }
        [DisplayName("商品次分類")]
        public string SubCategoryName { get { return Product.SubCategory.SubCategoryName; } } 
        [DisplayName("價格")]
        public decimal Price { get { return (decimal)this.Product.Price; } set { this.Product.Price = value; } }
        [DisplayName("成本")]
        public decimal Cost { get { return (decimal)this.Product.Cost; } set { this.Product.Cost = value; } }
        public int SupplierId { get { return (int)this.Product.SupplierId; } set { this.Product.SupplierId = value; } }
        [DisplayName("供應商")]
        public string SupplierName { get { return Product.Supplier.Name; } }
        public bool IsPet { get { return (bool)this.Product.IsPet; } set { this.Product.IsPet = value; } }
        [DisplayName("商品說明")]
        public string Description { get { return this.Product.Description; } set { this.Product.Description = value; } }
        [DisplayName("庫存")]
        public int UnitsInStock { get { return (int)this.Product.UnitsInStock; } set { this.Product.UnitsInStock = value; } }
        public List<string> PictureNames=new List<string>();

        [DisplayName("狀態")]
        public bool Continued { get { return (bool)this.Product.Continued; } set { this.Product.Continued = value; } }


    }
}

using Microsoft.AspNetCore.Http;
using prjMvcCoreDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace prjMvcCoreDemo.ViewModels
{
    public class CProductViewModel
    {
        public CProductViewModel()
        {
            _prod = new TProduct();
        }
        private TProduct _prod;
        public TProduct product { 
            get { return _prod; }
            set { _prod = value; } 
        }
        public int FId
        {
            get { return _prod.FId; }
            set { _prod.FId = value; }
        }
        [DisplayName("商品名稱")]
        public string FName
        {
            get { return _prod.FName; }
            set { _prod.FName = value; }
        }
        [DisplayName("成本")]
        public decimal? FCost
        {
            get { return _prod.FCost; }
            set { _prod.FCost = value; }
        }
        [DisplayName("庫存")]
        public int? FQty
        {
            get { return _prod.FQty; }
            set { _prod.FQty = value; }
        }
        [DisplayName("售價")]
        public decimal? FPrice
        {
            get { return _prod.FPrice; }
            set { _prod.FPrice = value; }
        }
        public string FImagePath
        {
            get { return _prod.FImagePath; }
            set { _prod.FImagePath = value; }
        }
        public IFormFile photo { get; set; }
    }
}

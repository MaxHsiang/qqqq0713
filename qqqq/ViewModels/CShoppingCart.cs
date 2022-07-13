using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace qqqq.ViewModels
{
    public class CShoppingCart
    {
       
        public int CartId { get; set; }
        [DisplayName("商品圖片")] 
        public string CartPhoto { get; set; }
        [DisplayName("商品名稱")]
        public string CartName { get; set; }
        [DisplayName("售價")]
        public decimal CartPrice { get; set; }
        [DisplayName("數量")]
        public int CartCount { get; set; }
        [DisplayName("小計")]
        public decimal TotalPrice { get { return (CartCount * CartPrice); } }

    }
}

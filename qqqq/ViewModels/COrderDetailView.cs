using qqqq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pet.ViewModels
{
    public class COrderDetailView
    {
        OrderDetail orderDetail;
        public COrderDetailView()
        {
            orderDetail=new OrderDetail();
        }
        public COrderDetailView(OrderDetail od)
        {
            orderDetail = od;
        }
        static public List<COrderDetailView> COrderDetailViews(List<OrderDetail> od)
        {
            List<COrderDetailView> list=new List<COrderDetailView>();
            foreach(var o in od )
            {
                COrderDetailView cOrderDetailView = new COrderDetailView(o);
                list.Add(cOrderDetailView);
            }
            return list;
        }
        public int OrderId { get { return orderDetail.OrderId; } }
        public int ProductId { get { return orderDetail.ProductId; } set { orderDetail.ProductId = value; } }
        public string ProductName { get { return orderDetail.Product.ProductName; } }
        public string UnitPrice { get { return ((decimal)orderDetail.UnitPrice).ToString("0"); } set { orderDetail.UnitPrice = decimal.Parse(value); } }
        public int? Quantity { get { return orderDetail.Quantity; } set { orderDetail.Quantity = value; } }
        public decimal Total { get { return (decimal)(orderDetail.UnitPrice * Quantity); } }
    }
}

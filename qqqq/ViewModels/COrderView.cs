using qqqq.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Pet.ViewModels
{
    public class COrderView
    {
        public COrderView()
        {
            order = new Order();
        }
        public COrderView(Order o)
        {
            order = o;
            details = new List<string>();
            foreach(OrderDetail od in o.OrderDetails)
            {
                string rr = od.Product.ProductName + " * " + od.Quantity;
                details.Add(rr);
            }
        }
        static public List<COrderView> COrderViews(List<Order> orders)
        {
            List<COrderView> list=new List<COrderView>();
            foreach(var o in orders)
            {
                COrderView cOrderView = new COrderView(o);
                list.Add(cOrderView);
            }
            return list;
        }
        public Order order;
        [DisplayName("訂單編號")]
        public int OrderId { get { return order.OrderId; } }
        [DisplayName("會員編號")]
        public int? MemberId { get { return order.MemberId; } set { order.MemberId = value; } }
        [DisplayName("員工編號")]
        public int? EmployeeId { get { return order.EmployeeId; } set { order.EmployeeId = value; } }
        [ DisplayName("訂單成立時間")]
        public DateTime? OrderDate { get { return order.OrderDate; } set { order.OrderDate = value; } }
        [DisplayName("訂單寄送地址")]
        public string SendAddress { get { return order.SendAddress; } set { order.SendAddress = value; } }

        public int? OrderStatusId { get { return order.OrderStatusId; } set { order.OrderStatusId = value; } }

        [DisplayName("訂單狀態")]
        public string OrderStatus { get { return order.OrderStatus.StatusType; } }
 
        public List<string> details;
        [DisplayName("訂單總金額")]
        public string OrderMoney { get { return (order.OrderDetails.Sum(o => (decimal)(o.UnitPrice * o.Quantity))).ToString("0")+"元";} }

    }
}

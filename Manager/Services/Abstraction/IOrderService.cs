using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Services.Abstraction
{
    public interface IOrderService
    {
        void CreateOrder(int customerID);
        Order GetOrderByID(int orderID);
        IEnumerable<Order> GetOrders();
        void UpdateOrder(int orderID, int customerID);
        void DeleteOrder(int orderID);
    }
}

using Manager.Services.Abstraction;
using Model.Models;
using Provider.Repositories.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Services.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void CreateOrder(int customerID)
        {
            _orderRepository.CreateOrder(customerID);
        }

        public void DeleteOrder(int orderID)
        {
            _orderRepository.DeleteOrder(orderID);
        }

        public Order GetOrderByID(int orderID)
        {
            return _orderRepository.GetOrderByID(orderID);
        }

        public IEnumerable<Order> GetOrders()
        {
            return _orderRepository.GetOrders();
        }

        public void UpdateOrder(int orderID, int customerID)
        {
            _orderRepository.UpdateOrder(orderID, customerID);
        }
    }
}


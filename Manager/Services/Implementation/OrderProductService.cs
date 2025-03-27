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
    public class OrderProductService : IOrderProductService
    {
        private readonly IOrderProductRepository _orderProductRepository;

        public OrderProductService(IOrderProductRepository orderProductRepository)
        {
            _orderProductRepository = orderProductRepository;
        }

        public void AddProductToOrder(int orderID, int productID, int quantity)
        {
            _orderProductRepository.AddProductToOrder(orderID, productID, quantity);
        }

        public Model.Models.OrderProduct GetProductInOrder(int orderID, int productID)
        {
            return _orderProductRepository.GetProductInOrder(orderID, productID);
        }

        public IEnumerable<Model.Models.OrderProduct> GetProductsByOrder(int orderID)
        {
            return _orderProductRepository.GetProductsByOrder(orderID);
        }

        public void RemoveProductFromOrder(int orderID, int productID)
        {
            _orderProductRepository.RemoveProductFromOrder(orderID, productID);
        }

        public void UpdateProductQuantityInOrder(int orderID, int productID, int quantity)
        {
            _orderProductRepository.UpdateProductQuantityInOrder(orderID, productID, quantity);
        }
    }
}


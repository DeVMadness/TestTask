using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Services.Abstraction
{
    public interface IOrderProductService
    {
        void AddProductToOrder(int orderID, int productID, int quantity);
        void RemoveProductFromOrder(int orderID, int productID);
        IEnumerable<OrderProduct> GetProductsByOrder(int orderID);
        void UpdateProductQuantityInOrder(int orderID, int productID, int quantity);
        OrderProduct GetProductInOrder(int orderID, int productID);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Manager.Services.Abstraction
{
    public interface IProductService
    {
        void CreateProduct(string name, decimal price);
        Product GetProductByID(int productID);
        IEnumerable<Product> GetProducts();
        void UpdateProduct(int productID, string name, decimal price);
        void DeleteProduct(int productID);
    }
}

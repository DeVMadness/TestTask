using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provider.Repositories.Abstraction
{
    public interface IProductRepository
    {
        void CreateProduct(string name, decimal price);
        Product GetProductByID(int productID);
        IEnumerable<Product> GetProducts();
        void UpdateProduct(int productID, string name, decimal price);
        void DeleteProduct(int productID);
    }
}

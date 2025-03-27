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
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void CreateProduct(string name, decimal price)
        {
            _productRepository.CreateProduct(name, price);
        }

        public void DeleteProduct(int productID)
        {
            _productRepository.DeleteProduct(productID);
        }

        public Product GetProductByID(int productID)
        {
            return _productRepository.GetProductByID(productID);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _productRepository.GetProducts();
        }

        public void UpdateProduct(int productID, string name, decimal price)
        {
            _productRepository.UpdateProduct(productID, name, price);
        }
    }
}


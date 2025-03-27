using Manager.Services.Abstraction;
using Model.Models;

namespace TestTaskWinForm.Controllers
{
     public class ProductController
     {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public void CreateProduct(string name, decimal price)
        {
            _productService.CreateProduct(name, price);
        }

        public Product GetProductByID(int productID)
        {
            return _productService.GetProductByID(productID);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _productService.GetProducts();
        }

        public void UpdateProduct(int productID, string name, decimal price)
        {
            _productService.UpdateProduct(productID, name, price);
        }

        public void DeleteProduct(int productID)
        {
            _productService.DeleteProduct(productID);
        }
    }
}

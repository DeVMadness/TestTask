using Microsoft.Data.SqlClient;
using Model.Models;
using Provider.Repositories.Abstraction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provider.Repositories.Implementation
{
    public class OrderProductRepository : IOrderProductRepository
    {
        private readonly string _connectionString;
        public OrderProductRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddProductToOrder(int orderID, int productID, int quantity)
        {
            throw new NotImplementedException();
        }

        public void CreateOrderProduct(int orderID, int productID, int quantity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("CreateOrderProduct", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@OrderID", orderID);
                    command.Parameters.AddWithValue("@ProductID", productID);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.ExecuteNonQuery();
                }
            }
        }

        public OrderProduct GetProductInOrder(int orderID, int productID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("GetOrderProductByOrderIDAndProductID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@OrderID", orderID);
                    command.Parameters.AddWithValue("@ProductID", productID);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new OrderProduct
                            {
                                OrderID = (int)reader["OrderID"],
                                ProductID = (int)reader["ProductID"],
                                Quantity = (int)reader["Quantity"]
                            };
                        }
                    }
                }
            }
            return null;
        }

        public void RemoveProductFromOrder(int orderID, int productID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("DeleteOrderProduct", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@OrderID", orderID);
                    command.Parameters.AddWithValue("@ProductID", productID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateProductQuantityInOrder(int orderID, int productID, int quantity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderProduct> GetProductsByOrder(int orderID)
        {
            var products = new List<OrderProduct>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("GetProductsByOrder", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@OrderID", orderID);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            products.Add(new OrderProduct
                            {
                                OrderID = (int)reader["OrderID"],
                                ProductID = (int)reader["ProductID"],
                                Quantity = (int)reader["Quantity"]
                            });
                        }
                    }
                }
            }
            return products;
        }
    }
}

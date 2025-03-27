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
    public class OrderRepository : IOrderRepository
    {
        private readonly string _connectionString;

        public OrderRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void CreateOrder(int customerID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("CreateOrder", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CustomerID", customerID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteOrder(int orderID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("DeleteOrder", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@OrderID", orderID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public Order GetOrderByID(int orderID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("GetOrderByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@OrderID", orderID);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Order
                            {
                                OrderID = reader.GetInt32(0),
                                CustomerID = reader.GetInt32(1),
                                OrderDate = reader.GetDateTime(2)
                            };
                        }
                    }
                }
            }
            return null;
        }

        public IEnumerable<Order> GetOrders()
        {
            var orders = new List<Order>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("GetOrders", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            orders.Add(new Order
                            {
                                OrderID = reader.GetInt32(0),
                                CustomerID = reader.GetInt32(1),
                                OrderDate = reader.GetDateTime(2)
                            });
                        }
                    }
                }
            }

            return orders;
        }

        public void UpdateOrder(int orderID, int customerID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("UpdateOrder", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@OrderID", orderID);
                    command.Parameters.AddWithValue("@CustomerID", customerID);
                    command.ExecuteNonQuery();
                }
            }
        }
    }

}

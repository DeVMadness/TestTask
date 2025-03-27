using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provider.Repositories.Abstraction
{
    public interface ICustomerRepository
    {
        void CreateCustomer(string name, string email, string phone, int UserId);
        Customer GetCustomerByID(int customerID);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int customerID);
    }
}

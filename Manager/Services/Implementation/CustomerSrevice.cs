using Manager.Services.Abstraction;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Provider.Repositories.Abstraction;

namespace Manager.Services.Implementation
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void CreateCustomer(string name, string email, string phone, int UserId)
        {
            _customerRepository.CreateCustomer(name, email, phone, UserId);
        }

        public void DeleteCustomer(int customerID)
        {
            _customerRepository.DeleteCustomer(customerID);
        }

        public Customer GetCustomerByID(int customerID)
        {
            return _customerRepository.GetCustomerByID(customerID);
        }

        public void UpdateCustomer(Customer customer)
        {
            _customerRepository.UpdateCustomer(customer);
        }
    }
}


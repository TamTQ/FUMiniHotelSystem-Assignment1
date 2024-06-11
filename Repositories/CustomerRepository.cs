using BusinessObjects;
using DataAccessLayer.DTO;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CustomerRepository : ICustomerRepository
    {
        public async Task AddCustomer(CustomerDTO customer) => await CustomerDAO.AddCustomer(customer);

        public async Task DeleteCustomer(int id) => await CustomerDAO.DeleteCustomer(id);

        public async Task<Customer?> GetCustomerByEmail(string email) => await CustomerDAO.GetCustomerByEmail(email);

        public async Task<Customer?> GetCustomerById(int id) => await CustomerDAO.GetCustomerById(id);

        public List<CustomerDTO> GetCustomers(Func<Customer, bool> predicate) => CustomerDAO.GetCustomers(predicate);

        public async Task<bool> UpdateCustomer(Customer customer) => await CustomerDAO.UpdateCustomer(customer);

        public async Task UpdateCustomer(CustomerDTO customer) => await CustomerDAO.UpdateCustomer(customer);

        public int CountCustomers() => CustomerDAO.CountCustomers();
    }
}


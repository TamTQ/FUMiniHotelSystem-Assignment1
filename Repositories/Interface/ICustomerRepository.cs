using BusinessObjects;
using DataAccessLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface ICustomerRepository
    {
        Task<Customer?> GetCustomerById(int id);
        Task<Customer?> GetCustomerByEmail(string email);
        Task<bool> UpdateCustomer(Customer customer);
        Task AddCustomer(CustomerDTO customer);
        Task DeleteCustomer(int id);
        Task UpdateCustomer(CustomerDTO customer);
        List<CustomerDTO> GetCustomers(Func<Customer, bool> predicate);
        int CountCustomers();
    }
}

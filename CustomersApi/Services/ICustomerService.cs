using CustomersApi.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomersApi.Services
{
    public interface ICustomerService
    {
        Task<List<Customers>> GetCustomers();
        void UpdateCustomers(Customers customers);
        void CreateCustomers(Customers customers);
        void DeleteCustomers(int id);
        bool Login(Login login);
        Customers GetCustomersById(int id);
    }
}

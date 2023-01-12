using CustomersApi.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomersApi.Data
{
    public interface ICustomerDao
    {
        Task<List<Customers>> GetCustomer();
        bool Update(Customers customers);
        void Create(Customers customers);
        bool Delete(int id);
        Task<Customers> GetCustomerById(int id);
        bool AdminLogin(string username, string password);
    }
}

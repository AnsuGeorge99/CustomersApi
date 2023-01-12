using CustomersApi.Data.DBContext;
using CustomersApi.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomersApi.Data
{
    public class CustomerDao : ICustomerDao
    {
        private readonly ApplicationDBContext _dbContext;
        public CustomerDao(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool AdminLogin(string username, string password)
        {
            var login = _dbContext.Login.ToList();
            return (login.Where(users => users.username == username && users.password == password).FirstOrDefault())==null?false:true;
        }



        public bool Delete(int id)
        {
            var result = _dbContext.Customers.ToListAsync().Result;
            _dbContext.Remove(result.Where(c=>c.CustomerId.Equals(id)).FirstOrDefault());
            _dbContext.SaveChangesAsync();
            return true;
        }

        public   Task<List<Customers>> GetCustomer()
        {
            return _dbContext.Customers.ToListAsync();
        }

        public async Task<Customers> GetCustomerById(int id)
        {
            var result = await _dbContext.Customers.ToListAsync();
            return (result.Where(c => c.CustomerId.Equals(id)).FirstOrDefault());
        }

        public bool Update(Customers customers)
        {
                _dbContext.Update(customers);
                _dbContext.SaveChanges();           
                return true;
        }

        void ICustomerDao.Create(Customers customers)
        {
            _dbContext.Add(customers);
             _dbContext.SaveChanges();
            
        }
    }
}

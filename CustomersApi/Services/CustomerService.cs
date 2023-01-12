using CustomersApi.Data;
using CustomersApi.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomersApi.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerDao _customerDao;
        public CustomerService(ICustomerDao customerDao)
        {
            _customerDao = customerDao;
        }
        public void CreateCustomers(Customers customers)
        {
            Customers values = new Customers();
            if (customers != null)
            {
                values.firstname = customers.firstname;
                values.lastname = customers.lastname;
                values.age = customers.age;
                values.DOB = customers.DOB;
                values.address = customers.address;
                _customerDao.Create(customers);
            }
        }

        public void DeleteCustomers(int id)
        {
            _customerDao.Delete(id);
        }

        public Task<List<Customers>> GetCustomers()
        {
           return _customerDao.GetCustomer();
        }

        public Customers GetCustomersById(int id)
        {
            return _customerDao.GetCustomerById(id).Result;
        }

        public bool Login(Login login)
        {
            return (_customerDao.AdminLogin(login.username, login.password));
        }

        public void UpdateCustomers(Customers customers)
        {
            if (customers != null)
            {
                var data = _customerDao.GetCustomer().Result.FirstOrDefault(x => x.CustomerId == customers.CustomerId);
                Customers result = new Customers();
                result = data;
                if (data != null)
                {
                    result.firstname = customers.firstname;
                    result.lastname = customers.lastname;
                    result.age = customers.age;
                    result.DOB = customers.DOB;
                    result.address = customers.address;
                    _customerDao.Update(result);
                }
            }      
        }

        
    }
}

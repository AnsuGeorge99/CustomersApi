using CustomersApi.Data.Models;
using CustomersApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomersApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomersController : Controller
    {
        private readonly ICustomerService _customersService;
        public CustomersController(ICustomerService customersService)
        {
            _customersService = customersService;
        }

        [HttpGet("getCustomers")]
        public async Task<IEnumerable<Customers>> GetCustomers()
        {
            try
            {
                var customers = await _customersService.GetCustomers();
                return customers;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpPost("customerPost")]
        public IActionResult CustomerPost(Customers customers)
        {
            try
            {
                _customersService.CreateCustomers(customers);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        
        [HttpPut("customerPut")]
        public IActionResult CustomerPut([FromBody] Customers customers)
        {
            try
            {
                _customersService.UpdateCustomers(customers);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpDelete("deleteCustomers/{id}")]
        public IActionResult DeleteCustomers(int id)
        {
            try
            {
                _customersService.DeleteCustomers(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpPost("adminLogin")]
        public IActionResult AdminLogin(Login login)
        {
            try 
            { 
                var result = _customersService.Login(login);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpGet("getCustomer/{id}")]
        public IActionResult GetCustomerById(int id)
        {
            return Ok(_customersService.GetCustomersById(id));
        }
    }
}

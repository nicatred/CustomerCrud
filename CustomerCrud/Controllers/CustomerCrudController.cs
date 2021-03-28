using CustomerCrud.Data.Entities;
using CustomerCrud.Data.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerCrudController : ControllerBase
    {
        ICustomerServices _customerServices;
        public CustomerCrudController(ICustomerServices customerServices)
        {
            _customerServices = customerServices;
        }
        [HttpGet]
        [Route("GetAllCustomers")]
        public List<Customer> GetAllCustomers()
        {      
           return _customerServices.GetAllCustomers();
        }
        [HttpGet("id")]
        [Route("GetCustomerById/{id}")]

        public Customer GetCustomer(int id)
        {
            return _customerServices.GetCustomerById(id);
        }
        [HttpPost]
        [Route("CreateCustomer")]
        public Customer CreateCustomer([FromBody]Customer customer)
        {
            return _customerServices.CreateCustomer(customer);
        }
        [Route("DeleteCustomer/{id}")]
        [HttpDelete("{id}")]
        public void DeleteCustomer(int id)
        {
            _customerServices.DeleteCustomer(id);
        }
        [Route("UpdateCustomer")]
        [HttpPut("{customer}")]
        public Customer UpdateCustomer([FromBody]Customer customer)
        {
            return _customerServices.UpdateCustomer(customer);
        }



    }
}

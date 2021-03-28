using CustomerCrud.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerCrud.Data.Services
{

    public interface ICustomerServices
    {
          List<Customer> GetAllCustomers();
       Customer GetCustomerById(int id);
       Customer CreateCustomer(Customer customer);
        Customer UpdateCustomer(Customer customer);
       void DeleteCustomer(int id);
    }
    public class CustomerServices : ICustomerServices
    {
        private AppDbContext _appDbContext;
        public CustomerServices(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Customer CreateCustomer(Customer customer)
        {
            _appDbContext.Customers.Add(customer);
            _appDbContext.SaveChanges();
            return customer;
        }

        public void DeleteCustomer(int id)
        {
            var customer = GetCustomerById(id);
            _appDbContext.Customers.Remove(customer);
            _appDbContext.SaveChanges();
        }

        public List<Customer> GetAllCustomers()
        {
            return _appDbContext.Customers.ToList();
        }

        public Customer GetCustomerById(int id)
        {
            return _appDbContext.Customers.Find(id);
        }

        public Customer UpdateCustomer(Customer customer)
        {
            _appDbContext.Customers.Update(customer);
            _appDbContext.SaveChanges();
            return customer;
        }
    }
}

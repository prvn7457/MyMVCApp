using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMVCApp.Models
{
    public class CustomerDbOperation
    {
        private List<Customer> Customers;

        public CustomerDbOperation()
        {
            Customers = new List<Customer>()
            {
                new Customer(){Id=1,Name="Rohit",Email="rohitj2@gmil.com",Mobile="288288282",Gender="Male"},
                new Customer(){Id=2,Name="Ritesh",Email="riteshj2@gmil.com",Mobile="348288282",Gender="Male"},
                new Customer(){Id=3,Name="Amit",Email="amitjj2@gmil.com",Mobile="438288282",Gender="Male"},
                new Customer(){Id=4,Name="Viji",Email="vijij2@gmil.com",Mobile="988288282",Gender="Female"},
            };
        }
        public List<Customer> GetCustomers()
        {
            return this.Customers;
        }
        public Customer AdCustomer(Customer obj)
        {
            this.Customers.Add(obj);
            return obj;
        }
    }
}

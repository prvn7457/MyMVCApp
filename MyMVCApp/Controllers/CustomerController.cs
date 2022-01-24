using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyMVCApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MyMVCApp.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext dbContext;
        public CustomerController(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public IActionResult Index()
        {
            //var customers = dbContext.customers.ToList();
            var locations = dbContext.Location.ToList();
            return View(locations);
        }
        public IActionResult CustomerList(int id)
        {
            var customers = dbContext.customers.Where(e => e.Location.Id == id);
            return View(customers);
        }
        public IActionResult CustomerDetail(int id)
        {
            var customer = dbContext.customers.SingleOrDefault(e => e.Id == id);
            return View(customer);
        }
    }
}

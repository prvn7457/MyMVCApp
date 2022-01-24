using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyMVCApp.Models
{
    

        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

            public ApplicationDbContext(DbSet<Customer> customers)
            {
                this.customers = customers;
            }

            public DbSet<Customer> customers { get; set; }
            public DbSet<Location> Location { get; set; }
    }
    }


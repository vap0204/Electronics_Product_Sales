using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Electronics_Product_Sales.Models
{
    //Connects the tables and the model classes using entity framework.
    public class Electronics_Product_SalesDataContext : DbContext
    {
        public Electronics_Product_SalesDataContext (DbContextOptions<Electronics_Product_SalesDataContext> options)
            : base(options)
        {
        }

        public DbSet<Electronics_Product_Sales.Models.Product> Product { get; set; }
        public DbSet<Electronics_Product_Sales.Models.Customer> Customer { get; set; }
        public DbSet<Electronics_Product_Sales.Models.Transaction> Transaction { get; set; }
    }
}

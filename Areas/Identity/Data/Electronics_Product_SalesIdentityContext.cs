using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Electronics_Product_Sales.Models
{
    public class Electronics_Product_SalesIdentityContext : IdentityDbContext<IdentityUser>
    {
        public Electronics_Product_SalesIdentityContext(DbContextOptions<Electronics_Product_SalesIdentityContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
           
        }
    }
}

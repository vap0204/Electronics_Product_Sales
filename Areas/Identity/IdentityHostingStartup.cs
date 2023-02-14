using System;
using Electronics_Product_Sales.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Electronics_Product_Sales.Areas.Identity.IdentityHostingStartup))]
namespace Electronics_Product_Sales.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Electronics_Product_SalesIdentityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Electronics_Product_SalesIdentityContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<Electronics_Product_SalesIdentityContext>();
            });
        }
    }
}
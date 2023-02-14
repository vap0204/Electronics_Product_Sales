using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Electronics_Product_Sales.Models
{
    //Customer registred with the site.
    public class Customer
    {
        //Customer id
        public int Id { get; set; }

        //Customer email
        public string Email { get; set; }

        //Name of the customer
        public string CustomerName { get; set; }


        //Customer address
        public string Address { get; set; }

        //Contact number
        public string ContactNumber { get; set; }

    }
}

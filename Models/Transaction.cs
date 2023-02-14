using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Electronics_Product_Sales.Models
{
    //A transaction
    public class Transaction
    {
        //Transaction id
        public int Id { get; set; }

        //Order id
        public string OrderId { get; set; }

        //Proudct id
        public int ProductId { get; set; }

        //Customer id
        public int CustomerId { get; set; }

        //Customer reference
        public Customer Customer { get; set; }

        //Product reference
        public Product Product { get; set; }




    }
}

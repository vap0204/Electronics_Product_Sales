using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Electronics_Product_Sales.Models
{
    // product
    public class Product
    {
        //Product id
        public int Id { get; set; }

        //Product name
        public string ProductName { get; set; }

        //Price of the product.
        public decimal ProductPrice { get; set; }

        //Product details
        public string ProductDescription { get; set; }

        //Product photo url
        public string ImageUrl { get; set; }

        //Product photo upload holder.
        [NotMapped]
        public IFormFile UploadedFile { get; set; }
    }
}

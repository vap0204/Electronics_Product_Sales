using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Electronics_Product_Sales.Models
{

    //A shopping cart.
    public class Cart
    {

    
       //List of products added  the cart
       public List<Product> Products { get; set; }

        //Order id.
       public string OrderId { get; set; }

        public Cart() {
           
            Products = new List<Product>();
        }


        //Add a product to cart.
        public void AddProduct(Product product ) {

            
            Products.Add(product);
        
        }


        //Remove  a product from cart
        public void Remove(int Id ) {

            var product = Products.First(p => p.Id == Id);
            Products.Remove(product);

        }
    }
}

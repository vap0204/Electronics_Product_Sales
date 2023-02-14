using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Electronics_Product_Sales.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Electronics_Product_Sales.Controllers
{
    //Carts controller
    public class CartsController : Controller
    {
        private readonly Electronics_Product_SalesDataContext _context;

        public CartsController(Electronics_Product_SalesDataContext context)
        {
            _context = context;
        }
        // GET: Carts
        //Get all products in the cart.
        public ActionResult Index()
        {
         
         string CartString = HttpContext.Session.GetString("cart");

            if (CartString != null)
            {

                Cart ShoppingCart = JsonSerializer.Deserialize<Cart>(CartString);
                return View(ShoppingCart.Products);
            }
            else {
                Cart ShoppingCart = new Cart();
                return View(ShoppingCart.Products);
            }

           

          
        }

        // GET: Carts/Edit/5
        //Add a product to cart.
        public ActionResult Add(int id)
        {

           

                string CartString = HttpContext.Session.GetString("cart");
                Cart ShoppingCart;
                if (CartString != null)
                {
                   
                    ShoppingCart = JsonSerializer.Deserialize<Cart>(CartString);

                }
                else {

                    ShoppingCart = new Cart();
                }

            Product product = (from products in _context.Product
                               where products.Id == id
                               select products).First();
              ShoppingCart.AddProduct(product);
                HttpContext.Session.SetString("cart", JsonSerializer.Serialize(ShoppingCart));

                return RedirectToAction(nameof(Index));
            
          
           
        }

     
       

        // GET: Carts/Delete/5
        //Remove the product from cart
        public ActionResult Delete(int id)
        {

            try
            {

                string CartString = HttpContext.Session.GetString("cart");
                Cart ShoppingCart = JsonSerializer.Deserialize<Cart>(CartString);

                ShoppingCart.Remove(id);
                HttpContext.Session.SetString("cart", JsonSerializer.Serialize(ShoppingCart));

                if (ShoppingCart.Products.Count == 0)
                {
                    return RedirectToAction(nameof(ProductsController.Index));

                }
                else {
                    return RedirectToAction(nameof(Index));
                }
               
            }
            catch
            {
                return View();
            }
           
        }

        
       
    }
}
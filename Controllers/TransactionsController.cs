using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Electronics_Product_Sales.Models;
using Microsoft.AspNetCore.Authorization;
using System.Text.Json;
using Microsoft.AspNetCore.Http;

namespace Electronics_Product_Sales.Controllers
{
   
    //Transactions controller
    public class TransactionsController : Controller
    {
        private readonly Electronics_Product_SalesDataContext _context;

        public TransactionsController(Electronics_Product_SalesDataContext context)
        {
            _context = context;
        }

        // GET: Transactions
        //Get all transaction using a lamda query Admin only
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var electronics_Product_SalesDataContext = _context.Transaction.Include(t => t.Customer).Include(t => t.Product);
            return View( electronics_Product_SalesDataContext.ToList());
        }

        // GET: Transactions/Details/5
        //Get transaction details admin only
        [Authorize(Roles = "Admin")]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction =  _context.Transaction
                .Include(t => t.Customer)
                .Include(t => t.Product)
                .FirstOrDefault(m => m.Id == id);
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

       

     
      //Get transaction for delete 

        // GET: Transactions/Delete/5
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction = _context.Transaction
                .Include(t => t.Customer)
                .Include(t => t.Product)
                .FirstOrDefault(m => m.Id == id);
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        // POST: Transactions/Delete/5
        //Delete transaction Admin only

        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var transaction = _context.Transaction.Find(id);
            _context.Transaction.Remove(transaction);
             _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        //Create the transaction with order id user only.
        [Authorize(Roles = "User")]
        public IActionResult Checkout() {


            string CartString = HttpContext.Session.GetString("cart");
            string customerId = HttpContext.Session.GetString("customerId");
            Cart ShoppingCart = JsonSerializer.Deserialize<Cart>(CartString);

            string orderId = "ORD_" + customerId+"_"+DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Second;
            ShoppingCart.Products.ForEach(p => {

                Transaction transaction = new Transaction();
                transaction.CustomerId = Int32.Parse(customerId);
                transaction.ProductId = p.Id;
                transaction.OrderId = orderId;

                _context.Add(transaction);
                _context.SaveChanges();
            });

            ShoppingCart.OrderId = orderId;
            return View(ShoppingCart);

        }

     
    }
}

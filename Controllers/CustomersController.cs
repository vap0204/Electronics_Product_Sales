using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Electronics_Product_Sales.Models;
using Microsoft.AspNetCore.Authorization;

namespace Electronics_Product_Sales.Controllers
{

    //Customer controller with Admin permission
    [Authorize(Roles = "Admin")]
    public class CustomersController : Controller
    {
        private readonly Electronics_Product_SalesDataContext _context;

        public CustomersController(Electronics_Product_SalesDataContext context)
        {
            _context = context;
        }

        // GET: Customers
        //Gets the customer uing a linq 
        public async Task<IActionResult> Index()
        {
            return View((from customer in _context.Customer select customer).ToList());
        }

        // GET: Customers/Details/5
        //Gets details  
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer =  _context.Customer
                .FirstOrDefault(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

       
       
        // GET: Customers/Edit/5
        //Gets the customer for edit using a linq 
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = (from customers in _context.Customer
                            where customers.Id == id
                            select customers).FirstOrDefault();
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        //Updates the customer.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Email,CustomerName,Address,ContactNumber")] Customer customer)
        {
            if (id != customer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Delete/5
        //Gets customer for delete 
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = _context.Customer
                .FirstOrDefault(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        //Deletes the customer.
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var customer =  _context.Customer.Find(id);
            _context.Customer.Remove(customer);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        //Customer exis check 
        private bool CustomerExists(int id)
        {
            return _context.Customer.Any(e => e.Id == id);
        }
    }
}

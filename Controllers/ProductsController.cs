using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Electronics_Product_Sales.Models;
using Microsoft.AspNetCore.Authorization;
using System.IO;

namespace Electronics_Product_Sales.Controllers
{
    
    //Products controller 
    public class ProductsController : Controller
    {
        private readonly Electronics_Product_SalesDataContext _context;

        public ProductsController(Electronics_Product_SalesDataContext context)
        {
            _context = context;
        }

        // GET: Products
        //Gets all products with user and admin permission.
        [Authorize(Roles = "User,Admin")]
        public IActionResult Index()
        {
            return View((from product in _context.Product select product).ToList());
        }

        // GET: Products/Details/5
        //Gets the details using a lamda query.
        [Authorize(Roles = "User,Admin")]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product =  _context.Product
                .FirstOrDefault(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        //Gets a product create form for admin.
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        //Creates  a product using a admin permission.
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,ProductName,ProductPrice,ProductDescription,UploadedFile")] Product product)
        {
            if (ModelState.IsValid)
            {


                UploadImage(product);
                _context.Add(product);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Edit/5
        //Gets the product fror edit using admin permission 
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = _context.Product.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        //Updates  the product 
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,ProductName,ProductPrice,ProductDescription,UploadedFile")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                     UploadImage(product);
                    _context.Update(product);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
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
            return View(product);
        }

        // GET: Products/Delete/5
        //Gets product for delete  admin only
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product =  _context.Product
                .FirstOrDefault(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        //Deletes the product admin only
        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var product =  _context.Product.Find(id);
            _context.Product.Remove(product);
             _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        //Check for existance 
        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.Id == id);
        }

        //Uploads an imge to products folder.
        private void UploadImage(Product Product) {

            if (Product.UploadedFile != null)
            {
                Product.ImageUrl = Product.UploadedFile.FileName;

                var filePath = "./wwwroot/products/" + Product.UploadedFile.FileName;


                if (Product.UploadedFile.Length > 0)
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        Product.UploadedFile.CopyTo(stream);
                    }
                }
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcCoreProject_Arif.Data;
using MvcCoreProject_Arif.Models;

namespace MvcCoreProject_Arif.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public readonly IHostingEnvironment _hostingEnvironment;

        public CustomersController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }
        public async Task<ActionResult> Index()
        {
            ViewBag.CustomerID = new SelectList(_context.Customers, "ID", "Name");
            return View(await _context.Customers.ToListAsync());
        }
        public ActionResult GetCustomerWiseFDRs(long? id)
        {
            if (id == null)
            {
                NotFound();
            }

            ViewData["id"] = id;
            List<FDR> fdrs = _context.FDRs.Where(e => e.CustomerID == id).ToList();

            if (fdrs == null)
            {
                NotFound();
            }

            return PartialView("CustomerWiseFDRs", fdrs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FDR fdrs, Customer customer, IFormFile[] Image)
        {
            try
            {

                if (Image != null)
                {
                    if (customer.FDRs.Count == Image.Count())
                    {
                        for (int i = 0; i < customer.FDRs.Count; i++)
                        {

                            string picture = System.IO.Path.GetFileName(Image[i].FileName);
                            var file = picture;
                            var uploadFile = Path.Combine(_hostingEnvironment.WebRootPath, "images", picture);

                            using (MemoryStream ms = new MemoryStream())
                            {
                                Image[i].CopyTo(ms);
                                customer.FDRs[i].Image = ms.GetBuffer();
                            }
                        }
                    }
                    _context.Customers.Add(customer);
                    _context.SaveChanges();
                    TempData["id"] = customer.ID;
                    return RedirectToAction("Index");
                }

                return View(customer);
            }
            catch (Exception)
            {
                return View(customer);
            }
        }

       
        public IActionResult Delete(long id)
        {
            Customer customer = _context.Customers.Find(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        public IActionResult DeleteFDR(long id)
        {
            FDR fdr = _context.FDRs.Find(id);
            if (fdr != null)
            {
                _context.FDRs.Remove(fdr);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            return RedirectToAction("Index");
        }
    }
}
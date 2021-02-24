using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcCoreProject_Arif.Data;
using MvcCoreProject_Arif.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MvcCoreProject_Arif.Controllers
{
    public class LoanController : Controller
    {
        private ILoanRepository db;

        private IBranchRepository db2;

        private readonly ApplicationDbContext _context;


        public LoanController(ILoanRepository db, IBranchRepository db2, ApplicationDbContext _context)
        {
            this.db = db;
            this.db2 = db2;

            this._context = _context;
        }
        public IActionResult Index()
        {

            //ViewBag.CourseName = db2.GetAll();
            //var applicationDbContext = _context.Courses.Include(t => t.CourseName);
            var applicationDbContext = _context.Branches.ToList();

            return View(db.GetAll());
        }



        // GET:Create
        public IActionResult Create()
        {
            ViewBag.BranchID = db2.GetAll();

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Loan trainee)
        {
            ViewBag.BranchID = db2.GetAll();
            db.Add(trainee);
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var applicationDbContext = _context.Branches.ToList();
            ViewBag.BranchID = db2.GetAll();

            return View(db.GetLoan(id));
        }

        [HttpPost]
        public IActionResult Edit(Loan trainee)
        {
            ViewBag.BranchID = db2.GetAll();
            db.Update(trainee);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            return View(db.GetLoan(id));
        }
    }
}
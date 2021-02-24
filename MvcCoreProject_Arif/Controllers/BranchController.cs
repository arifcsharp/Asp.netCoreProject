using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcCoreProject_Arif.Models;
using Microsoft.AspNetCore.Mvc;

namespace MvcCoreProject_Arif.Controllers
{
    public class BranchController : Controller
    {
        private IBranchRepository db;

        public BranchController(IBranchRepository db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View(db.GetAll());
        }



        // GET:Create
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Branch branch)
        {

            db.Add(branch);
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            return View(db.GetBranch(id));
        }

        [HttpPost]
        public IActionResult Edit(Branch branch)
        {
            db.Update(branch);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            return View(db.GetBranch(id));
        }
    }
}
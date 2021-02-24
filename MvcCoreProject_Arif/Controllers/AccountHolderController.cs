using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcCoreProject_Arif.Models;

namespace MvcCoreProject_Arif.Controllers
{
    public class AccountHolderController : Controller
    {
        private IAccountHolderRepository db;
        public AccountHolderController(IAccountHolderRepository db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View(db.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AccountHolder accountHolder)
        {
            db.Add(accountHolder);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            return View(db.GetAccountHolder(id));
        }

        [HttpPost]
        public IActionResult Edit(AccountHolder accountHolder)
        {
            db.Update(accountHolder);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            return View(db.GetAccountHolder(id));
        }

    }
}

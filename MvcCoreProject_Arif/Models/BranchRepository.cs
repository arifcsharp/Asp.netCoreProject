using MvcCoreProject_Arif.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreProject_Arif.Models
{
    public class BranchRepository:IBranchRepository
    {
        private readonly ApplicationDbContext db;
        public BranchRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public Branch Add(Branch branch)
        {
            db.Branches.Add(branch);
            db.SaveChanges();

            return branch;
        }
      
        public Branch Delete(int id)
        {
            Branch branch = db.Branches.Find(id);
            if (branch != null)
            {
                db.Branches.Remove(branch);
                db.SaveChanges();
            }
            return branch;
        }

        public IEnumerable<Branch> GetAll()
        {
            return db.Branches;
        }

        public Branch GetBranch(int id)
        {
            return db.Branches.Where(x => x.BranchID == id).SingleOrDefault();
        }

        public Branch Update(Branch branch)
        {
            db.Entry(branch).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return branch;
        }
    }
}

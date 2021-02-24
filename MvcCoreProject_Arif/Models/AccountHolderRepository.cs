using MvcCoreProject_Arif.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreProject_Arif.Models
{
    public class AccountHolderRepository : IAccountHolderRepository
    {
        private readonly ApplicationDbContext db;
        public AccountHolderRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public AccountHolder Add(AccountHolder AccountHolder)
        {
            db.AccountHolders.Add(AccountHolder);
            db.SaveChanges();

            return AccountHolder;
        }

       
        public AccountHolder Delete(int Id)
        {
            AccountHolder AccountHolder = db.AccountHolders.Find(Id);
            if (AccountHolder != null)
            {
                db.AccountHolders.Remove(AccountHolder);
                db.SaveChanges();
            }
            return AccountHolder;
        }

        public AccountHolder GetAccountHolder(int Id)
        {
            return db.AccountHolders.Where(x => x.Id == Id).SingleOrDefault();
        }

        public IEnumerable<AccountHolder> GetAll()
        {
            return db.AccountHolders;
        }

        //public void SaveChanges()
        //{
        //    throw new NotImplementedException();
        //}

        public AccountHolder Update(AccountHolder accountHolder)
        {
            db.Entry(accountHolder).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return accountHolder;
        }

        
    }
}

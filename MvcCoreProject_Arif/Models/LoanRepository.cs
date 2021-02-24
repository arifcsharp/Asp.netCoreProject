using MvcCoreProject_Arif.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreProject_Arif.Models
{
    public class LoanRepository:ILoanRepository
    {
        private readonly ApplicationDbContext db;
        public LoanRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public Loan Add(Loan loan)
        {
            db.Loans.Add(loan);
            db.SaveChanges();

            return loan;
        }

        public Loan Delete(int id)
        {
            Loan loan = db.Loans.Find(id);
            if (loan != null)
            {
                db.Loans.Remove(loan);
                db.SaveChanges();
            }
            return loan;
        }

        public IEnumerable<Loan> GetAll()
        {
            return db.Loans;
        }

        public Loan GetLoan(int id)
        {
            return db.Loans.Where(x => x.LoanID == id).SingleOrDefault();
        }

        public Loan Getloan(int id)
        {
            throw new NotImplementedException();
        }

        public Loan Update(Loan loan)
        {
            db.Entry(loan).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return loan;
        }
    }
}

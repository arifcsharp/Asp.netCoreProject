using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreProject_Arif.Models
{
    public interface ILoanRepository
    {
        Loan GetLoan(int id);

        IEnumerable<Loan> GetAll();

        Loan Add(Loan loan);
        Loan Update(Loan loan);
        Loan Delete(int id);
    }
}

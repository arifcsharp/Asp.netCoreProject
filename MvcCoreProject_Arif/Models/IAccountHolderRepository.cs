using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreProject_Arif.Models
{
    public interface IAccountHolderRepository
    {
        AccountHolder GetAccountHolder(int Id);

        IEnumerable<AccountHolder> GetAll();


        AccountHolder Add(AccountHolder AccountHolder );
        AccountHolder Update(AccountHolder AccountHolder );
        AccountHolder Delete(int Id);
        //void SaveChanges();
    }
}

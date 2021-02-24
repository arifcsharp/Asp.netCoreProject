using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreProject_Arif.Models
{
    public interface IBranchRepository
    {
        Branch GetBranch(int id);

        IEnumerable<Branch> GetAll();

        Branch Add(Branch branch);
        Branch Update(Branch branch);
        Branch Delete(int id);
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreProject_Arif.Models
{
    public class Branch
    {
        [Key]
        public int BranchID { get; set; }


        [Display(Name = "Branch Name")]
        [Required(ErrorMessage = "Must Be Filled")]
        
        public string BranchName { get; set; }

       
        [Required(ErrorMessage = "Must Be Filled")]
        public string City { get; set; }

       
        public virtual ICollection<Loan> Loans { get; set; }
    }
}

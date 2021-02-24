using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreProject_Arif.Models
{
    public class Loan
    {
        [Key]
        public int LoanID { get; set; }
        public int BranchID { get; set; }

        [Display(Name = "Client Name")]
        [Required(ErrorMessage = "Must Be Filled")]
        
        public string Name { get; set; }

        [Display(Name = "Permanent Address")]
        [Required(ErrorMessage = "Must Be Filled")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Must Be Filled")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Contact Number")]
        [Required(ErrorMessage = "Must Be Filled")]
        public string CellPhone { get; set; }

        public virtual Branch Branch { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreProject_Arif.ViewModels
{
    public class EmployeeViewModel:EditImageViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public string EmployeeName { get; set; }

        [Required]
        public string Qualification { get; set; }

        [Required]
        public int Experience { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Joining Date")]
        public DateTime JoiningDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Resign Date")]
        public DateTime ResignDate { get; set; }

        [Required]
        public string Address { get; set; }
    }
}

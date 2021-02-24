using MvcCoreProject_Arif.CustomValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreProject_Arif.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Name")]
        [MyAttribute]
        public string EmployeeName { get; set; }

        [Required]
        [StringLength(100)]
        public string Qualification { get; set; }

        [Required]
        [StringLength(100)]
        public int Experience { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Joining Date")]
        public DateTime JoiningDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Resign Date")]
        public DateTime ResignDate{ get; set; }

        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Image")]
        public string ProfilePicture { get; set; }
    }
}

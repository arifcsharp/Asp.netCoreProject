using MvcCoreProject_Arif.CustomValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreProject_Arif.Models
{
    public class AccountHolder
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This Field is required")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Enter minimum 2 or maximum 30 character")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        
        [Display(Name = "Account Name")]
        public string Name { get; set; }

        [MyAttribute]
        [Required(ErrorMessage = "This Field is required")]
        [Display(Name = "Father's Name")]
        
        public string fatherName { get; set; }

        

        [Required(ErrorMessage = "This Field is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "This Field is required")]
        [Range(18, 60)]
        public int Age { get; set; }


        [Required(ErrorMessage = "This Field is required")]
        [DataType(DataType.Date)]
        [CustomHireDate(ErrorMessage = "Hire Date must be less than or equal to Today's Date")]
        [Display(Name = "A/c Opening Date")]
        public DateTime OpeningDate { get; set; }


        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter confirm password")]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and confirm password does not match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }





        



    }
}

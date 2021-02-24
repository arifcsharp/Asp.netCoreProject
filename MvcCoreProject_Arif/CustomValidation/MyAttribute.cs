using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcCoreProject_Arif.CustomValidation
{
    public class MyAttribute: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string message = value.ToString();
                if (message.Contains("Mr."))
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult("Must be Use Mr.");
        }
    }
}
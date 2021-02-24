using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MvcCoreProject_Arif.CustomValidation;

namespace MvcCoreProject_Arif.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        
        [DisplayName("Account Number")]
        [Required(ErrorMessage = "Must be filled account number")]
        
        public string AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Receiver Name")]
        [Required(ErrorMessage = "Please input branch name")]
        [MyAttribute]
        public string BeneficiaryName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Bank Name")]
        [Required(ErrorMessage = "Please input bank name")]
        public string BankName { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("SWIFT Code")]
        [Required(ErrorMessage = "please input your SWIFT code.")]
        [MaxLength(11)]
        public string SWIFTCode { get; set; }

        [DisplayName("Amount")]
        [Required(ErrorMessage = "must be filled amount.")]
        public int Amount { get; set; }

        //[DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}")]
        [DataType(DataType.Date)]
        [DisplayName("Transaction Date")]
        public DateTime Date { get; set; }
    }
}

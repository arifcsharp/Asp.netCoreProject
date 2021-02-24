using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreProject_Arif.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public long ID { get; set; }

        [Required, Display(Name = "Category")]
        public string Name { get; set; }

        public virtual IList<FDR> FDRs { get; set; }
    }
}

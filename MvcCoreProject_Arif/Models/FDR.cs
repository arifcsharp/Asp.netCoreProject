using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreProject_Arif.Models
{
    [Table("FDR")]
    public class FDR
    {
        [Key]
        public long ID { get; set; }

        [Required, Display(Name = "Product Name")]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        public string AccountDetails { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        [DataType(DataType.Date)]

        public DateTime OpeningDate { get; set; }

        [Required]
        public long Quantity { get; set; }

        [ForeignKey("Customer")]
        public long CustomerID { get; set; }


        public virtual Customer Customer{ get; set; }
    }
}

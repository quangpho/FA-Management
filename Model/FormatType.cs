using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Model
{
   public class FormatType
    {
        [Key]

        public int FormatTypeID { get; set; }


        [Required]
        public string FormatTypeName { get; set; }
        [MaxLength(500)]
        public string Remark { get; set; }
        public virtual ICollection<ClassBatch> ClassBatch { get; set; }
    }
}

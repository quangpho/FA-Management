using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Model
{
   public class SubjectType
    {
        [Key]
        public int SubjectTypeID { get; set; }
        [MaxLength(50)]
        [Required]
        public string SucjectName { get; set; }

        [MaxLength(500)]
        public string Remark { get; set; }
       
        
        public virtual ICollection<ClassBatch> ClassBatch { get; set; }
    }
}

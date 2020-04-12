using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Model
{
   public class Scope
    {
        [Key]
        public int ScopeID { get; set; }

        [Required]
        public string ScopeName { get; set; }
        [MaxLength(500)]
        public string Remark { get; set; }
      
        public virtual ICollection<ClassBatch> ClassBatch { get; set; }
    }
}

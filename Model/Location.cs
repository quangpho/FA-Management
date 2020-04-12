using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Model
{
   public class Location
    {
        [Key]
        public int LocationID { get; set; }
       
        [MaxLength(500)]
        public string Remark { get; set; }
        [Required]
        [MaxLength(20)]
        public string LocationName { get; set; }
        
        [MaxLength(10)]
        public string Acronym { get; set; }
        public virtual ICollection<ClassBatch> ClassBatch { get; set; }
    }
}

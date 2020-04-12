using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Model
{
  public class Trainer
    {   
        [Key]
        public int TrainerID { get; set; }
       
        public int Type { get; set; }
      
        [MaxLength(500)]
        public string Remark { get; set; }
        public virtual ICollection<ClassBatch> ClassBatch { get; set; }
        public virtual TrainerProfile TrainerProfile { get; set; }
    }
}

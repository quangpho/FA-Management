using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Model
{
   public class DelivaryType
    {
        [Key]
        public int DelivaryID { get; set; }
        public string DeliveryName { get; set; }
        [MaxLength(500)]
        public string Remark { get; set; }
        public virtual ICollection<ClassBatch> ClassBatch { get; set; }
    }
}

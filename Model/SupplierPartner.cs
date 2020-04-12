using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Model
{
   public class SupplierPartner
    {
        [Key]
        [ForeignKey("ClassBatch")]
        public int SupplierPartnerID { get; set; }
        [MaxLength(500)]
       
        public string SupplierPartnerName { get; set; }
        public string Remark { get; set; }
       
        public virtual ClassBatch ClassBatch { get; set; }
    }
}

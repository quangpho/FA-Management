using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Model
{
   public class Audit
    {
        [Key]
        public int AuditID { get; set; }
        [ForeignKey("ClassBatch")]
        public int ClassBatchID { get; set; }
        public virtual ClassBatch ClassBatch { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Date { get; set; }
        [ForeignKey("EventCatagory")]
        public int? EventCatogoryID { get; set; }
        public virtual EventCatagory EventCatagory { get; set; }
        [MaxLength(50)]
        public string RelatedPatyPeople { get; set; }
        [MaxLength(50)]
        public string Action { get; set; }

        [MaxLength(50)]
        public string PIC { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Deadline { get; set; }
        public string Note { get; set; }

    }
}

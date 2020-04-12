using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Model
{
   public class Budget
    {
        [Key]
        public int BudgetID { get; set; }

        [Required]
        public string BudgetName { get; set; }

        [MaxLength(500)]
        public string Remark { get; set; }
        public virtual ICollection<ClassBatch> ClassBatch { get; set; }

    }
}

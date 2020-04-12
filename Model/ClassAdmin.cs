using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
   public class ClassAdmin
    {
        [Key]
      
        public int ClassAdminID { get; set; }

        [MaxLength(10)]
        public string Account { get; set; }
        [MaxLength(50)]
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }


        public string Phone { get; set; }
        [MaxLength(60)]
        //  [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", ErrorMessage = "Wrong Format")]
        public string Email { get; set; }
        [MaxLength(500)]
        public string Remark { get; set; }
        public virtual ICollection<ClassBatch> ClassBatch { get; set; }
       
    }
}

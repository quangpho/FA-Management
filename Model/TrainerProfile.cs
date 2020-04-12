using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Model
{
   public class TrainerProfile
    {
        [Key]
        [ForeignKey("Trainer")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TrainerProfileID { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "")]
        public string FullName { get; set; }
        [MaxLength(10)]
        public string Account { get; set; }
       
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        [MaxLength(50)]
        public string Unit { get; set; }
        [MaxLength(250)]
        public string Major { get; set; }
       
       // [RegularExpression(@"^(?:(?:\+?1\s*(?:[.-]\s*)?)?(?:\(\s*([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9])\s*\)|([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9]))\s*(?:[.-]\s*)?)?([2-9]1[02-9]|[2-9][02-9]1|[2-9][02-9]{2})\s*(?:[.-]\s*)?([0-9]{4})(?:\s*(?:#|x\.?|ext\.?|extension)\s*(\d+))?$", ErrorMessage = "Wrong Fomat")]
        public string Phone { get; set; }
        [MaxLength(60)]
      
        public string Email { get; set; }

        public string Experience { get; set; }

       
        [MaxLength(500)]
        public string Remark { get; set; }
        public virtual Trainer Trainer { get; set; }
    }
}

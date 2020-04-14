using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class StatusInClass
	{
        [Key]
        public int StatusInClassId { get; set; }
        public string StatusInClassName { get; set; }
        [StringLength(250)]
        public string Remarks { get; set; }

        public int? BatchClassID { get; set; }

        public virtual ICollection<Trainee> Trainees { get; set; }
    }
}

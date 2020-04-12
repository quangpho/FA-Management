using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Model
{
  public class EventCatagory
    {
        [Key]
        public int EventCatagoryID { get; set; }
        public string EveCatagoryName { get; set; }
        public virtual ICollection<Audit> Audit { get; set; }
    }
}

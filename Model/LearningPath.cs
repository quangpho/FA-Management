using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Model
{
   public class LearningPath
    {
        [Key]
        [ForeignKey("ClassBatch")]
        public int LearningPathID { get; set; }
    
        [Required]
        public string LearningPathName { get; set; }
        public string RelatefInformation { get; set; }
        public virtual ClassBatch ClassBatch { get; set; }






    }
}

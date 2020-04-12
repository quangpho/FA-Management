using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Interview
    {
        [Key]
        public int Id { get; set; }
   
        public decimal Time { get; set; }
        public DateTime Date { get; set; }
        public int Interviewer { get; set; }
        public int Comments { get; set; }
        public int Result { get; set; }
        public string Remarks { get; set; }

        [ForeignKey("Candidate")]
        public int CandidateId { get; set; }

        public virtual Candidate Candidate { get; set; }
    }
}

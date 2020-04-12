using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EntryTest
    {
        [Key]
        public int Id { get; set; }

        public decimal Time { get; set; }
        public DateTime Date { get; set; }
        public int LangguageValuator { get; set; }
        public int LangguageResult { get; set; }
        public int TechnicalValuator { get; set; }
        public int TechnicalResult { get; set; }
        public int Result { get; set; }
        public string Remarks { get; set; }

        [ForeignKey("Candidate")]
        public int CandidateId { get; set; }

        public virtual Candidate Candidate { get; set; }
    }
}

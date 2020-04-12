using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Offer
    {
        [Key]
        public int Id { get; set; }

        public int Jobrank { get; set; }
        public int Technology { get; set; }
        public int ContractType { get; set; }
        public int OfferSalary { get; set; }
        public string Remarks { get; set; }

        [ForeignKey("Candidate")]
        public int CandidateId { get; set; }

        public virtual Candidate Candidate { get; set; }
    }
}

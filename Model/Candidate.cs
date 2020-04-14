using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Candidate
    {
        [Key]
        public int Id { get; set; }

        public DateTime? ApplicationDate { get; set; }
        public int? LocationId { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
        [ForeignKey("Channel")]
        [Required(ErrorMessage = "You must input all required fields!")]
        public int ChannelId { get; set; }

        public virtual Channel Channel { get; set; }
        public virtual TraineeCandidateProfile TraineeCandidateProfile { get; set; }
        public virtual ICollection<Interview> Interviews { get; set; }
        public virtual ICollection<Offer> Offers { get; set; }

        public virtual ICollection<EntryTest> EntryTests { get; set; }
    }
}

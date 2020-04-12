using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Channel
    {
        [Key]
        public int Id { get; set; }
        public int EmplId { get; set; }
        public string ChannelName { get; set; }
        public string Remarks { get; set; }

        public virtual ICollection<Candidate> Candidates { get; set; }
    }
}

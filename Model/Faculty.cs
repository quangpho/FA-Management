using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Faculty
    {
        [Key]
        public int Id { get; set; }
        public string FacultyName { get; set; }
        public string Remarks { get; set; }

        public virtual ICollection<TraineeCandidateProfile> TraineeCandidateProfiles { get; set; }
    }
}

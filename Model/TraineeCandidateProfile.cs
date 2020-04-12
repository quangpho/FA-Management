using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;


namespace Model
{
    public class TraineeCandidateProfile
    {
        [Key, ForeignKey("Candidate")]
        public int Id { get; set; }

        [Required(ErrorMessage = "You must input all required fields")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "You must input all required fields")]
        [CustomDateTimeValidation]
        public DateTime DOB { get; set; }
        [Required(ErrorMessage = "You must input all required fields")]
        public bool Gender { get; set; }

        [CustomDateTimeValidation]
        public DateTime? GraduationDate { get; set; }

        
        [Index(IsUnique = true)]
        [Required(ErrorMessage = "You must input all required fields")]
        [CustomPhoneValidation]
        [StringLength(14)]
        public string Phone { get; set; }

        [Index(IsUnique = true)]
        [Required(ErrorMessage = "You must input all required fields")]
        [EmailAddress(ErrorMessage = "Email is Wrong format.")]
        [StringLength(50)]
        public string Email { get; set; }
        public string Type { get; set; }
        public int? Skill { get; set; }
        public string ForeignLangguage { get; set; }
        public int? Level { get; set; }
        public string AllocationStatus { get; set; }
        public string History { get; set; }
        public string Remarks { get; set; }
        [ForeignKey("University")]
        [Required(ErrorMessage = "You must input all required fields")]
        public int UniversityId { get; set; }
        [ForeignKey("Faculty")]
        [Required(ErrorMessage = "You must input all required fields")]
        public int FacultyId { get; set; }

        public virtual Trainee Trainee { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual University University { get; set; }
        public virtual Faculty Faculty { get; set; }

    }
}

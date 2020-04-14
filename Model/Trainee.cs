namespace Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("Trainee")]
    public partial class Trainee
    {

        [Key, ForeignKey("TraineeCandidateProfile")]
        public int TraineeCandidateID { get; set; }

        [ForeignKey("ClassBatch")]
        public int? ClassID { get; set; }

        [StringLength(250)]
        public string Remarks { get; set; }
        [ForeignKey("Status")]
        public int StatusID { get; set; }
        [ForeignKey("StatusInClass")]
        public int StatusInClassId { get; set; }

        public virtual ICollection<Allowance> Allowances { get; set; }

        public virtual ICollection<AttendantStatus> AttendantStatus { get; set; }

        public virtual ICollection<GPA> GPAs { get; set; }

        public virtual ICollection<Guarantee> Guarantees { get; set; }

        public virtual ICollection<InterviewValuation> InterviewValuations { get; set; }

        public virtual ICollection<MilestoneConfiguration> MilestoneConfigurations { get; set; }

        public virtual ICollection<RewardPenalty> RewardPenalties { get; set; }

        public virtual Status Status { get; set; }
        public virtual StatusInClass StatusInClass { get; set; }
        public virtual TraineeCandidateProfile TraineeCandidateProfile { get; set; }

        public virtual ClassBatch ClassBatch { get; set; }
    }
}

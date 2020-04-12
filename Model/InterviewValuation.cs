namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InterviewValuation")]
    public partial class InterviewValuation
    {
        [Key]
        [Column("InterviewValuation")]
        public int InterviewValuation1 { get; set; }
        [ForeignKey("Trainee")]
        public int? TraineeID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        [StringLength(50)]
        public string Interviewer { get; set; }

        [StringLength(250)]
        public string Remarks { get; set; }

        public virtual Trainee Trainee { get; set; }
    }
}

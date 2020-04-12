namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GPA")]
    public partial class GPA
    {
        [Key]
        public int GPA_ID { get; set; }
        [ForeignKey("Trainee")]
        public int? TraineeID { get; set; }

        public int? ClassID { get; set; }

        public int? AttentdantID { get; set; }

        public int? AllowanceID { get; set; }
        public string Milestone { get; set; }
        public int AcademicMark { get; set; }
        public int DisciplinaryPoint { get; set; }
        public int Bonus { get; set; }
        public int Penalty { get; set; }

        public int? GPA_Result { get; set; }

        [StringLength(250)]
        public string Remarks { get; set; }

        public virtual Trainee Trainee { get; set; }
    }
}

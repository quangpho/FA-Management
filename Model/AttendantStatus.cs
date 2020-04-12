namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AttendantStatus
    {
        [Key]
        public int AttendantID { get; set; }

        public int? TraineeID { get; set; }

        public int? DisciplinePoint { get; set; }

        [StringLength(50)]
        public string Milestones { get; set; }
        public DateTime? LearningDay { get; set; }
        public string StatusDate { get; set; }

        [StringLength(250)]
        public string Remarks { get; set; }

        public virtual Trainee Trainee { get; set; }
    }
}

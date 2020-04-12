namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MilestoneConfiguration")]
    public partial class MilestoneConfiguration
    {
        [Key]
        public int MilestoneConfigurationId { get; set; }
        public string MilestoneName { get; set; }

        public int TraineeID { get; set; }

        public bool? SalaryPaid { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? AverageScore { get; set; }
        [ForeignKey("Trainee")]
        public int? TraineeCandidateID { get; set; }
        public virtual ICollection<Topic> Topics { get; set; }

        public virtual Trainee Trainee { get; set; }
    }
}

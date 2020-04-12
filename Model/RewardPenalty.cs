namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RewardPenalty")]
    public partial class RewardPenalty
    {
        [Key]
        public int RewardPenaltyID { get; set; }
        [ForeignKey("Trainee")]
        public int? TraineeID { get; set; }

        [StringLength(50)]
        public string Milestone { get; set; }

        public int BonusPoint { get; set; }
        public int PenaltyPoint { get; set; }
        public DateTime Date { get; set; }
        [StringLength(250)]
        public string Reason { get; set; }

        public virtual Trainee Trainee { get; set; }
    }
}

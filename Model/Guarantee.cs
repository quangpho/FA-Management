namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Guarantee")]
    public partial class Guarantee
    {
        [Key]
        public int GuaranteeID { get; set; }
        [ForeignKey("Trainee")]
        public int? TraineeID { get; set; }

        [StringLength(20)]
        public string FSU { get; set; }

        public int? Comments { get; set; }
        public float Salary { get; set; }
        public DateTime StartDate { get; set; }
        public string AllocationStatus { get; set; }
        public string Remarks { get; set; }
        public virtual Trainee Trainee { get; set; }
    }
}

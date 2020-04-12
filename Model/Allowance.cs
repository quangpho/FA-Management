namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Allowance")]
    public partial class Allowance
    {
        [Key]
        public int AllowanceId { get; set; }
        [ForeignKey("Trainee")]
        public int? TraineeID { get; set; }
        public int? ClassID { get; set; }

        public int? AllowanceResult { get; set; }
        public string Milestone { get; set; }
        public bool SalaryPaid { get; set; }
        public string Level { get; set; }
        public int GPA { get; set; }
        public int StandardAllowance { get; set; }
        [StringLength(250)]
        public string Remarks { get; set; }

        public virtual Trainee Trainee { get; set; }
        //public virtual AllowanceGroup AllowanceGroup { get; set; }
    }
}

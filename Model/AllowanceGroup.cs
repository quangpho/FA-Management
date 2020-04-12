namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AllowanceGroup")]
    public partial class AllowanceGroup
    {
        [Key]
        public string Group { get; set; }

        public int? Allowances { get; set; }

        [StringLength(250)]
        public string Remarks { get; set; }
        //public virtual Allowance Allowance { get; set; }
    }
}

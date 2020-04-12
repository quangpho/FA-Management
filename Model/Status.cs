namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Status
    {
        [Key]
        public int StatusID { get; set; }
        public string StatusName { get; set; }
        [StringLength(250)]
        public string Remarks { get; set; }

        public int? BatchClassID { get; set; }

        //public virtual ICollection<Trainee> Trainees { get; set; }

    }
}

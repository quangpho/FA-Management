using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Model
{
    public class ClassBatch
    {
        [Key]
        public int ClassID { get; set; }
        [Required(ErrorMessage = "ClassName must be not empty")]
        [MaxLength(50)]
        public string ClassName { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "ClassCode must be not empty")]
        public string ClassCode { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? ExpectedStartDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? ExpectedEndDate { get; set; }
        [MaxLength(250)]
        public string DetailLocation { get; set; }
        [ForeignKey("Trainer")]
        public int TrainerID { get; set; }
        public virtual Trainer Trainer { get; set; }
        [ForeignKey("ClassAdmin")]
        public int ClassAdminID { get; set; }
        public virtual ClassAdmin ClassAdmin { get; set; }
        [ForeignKey("Location")]
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        [ForeignKey("SubjectType")]
        public int SubjectTypeID { get; set; }
        public virtual SubjectType SubjectType { get; set; }
        [ForeignKey("Sub_SubjectType")]
        public int Sub_SubjectTypeID { get; set; }
        public virtual Sub_SubjectType Sub_SubjectType { get; set; }
        [ForeignKey("DelivaryType")]
        public int? DelivaryTypeID { get; set; }
        public virtual DelivaryType DelivaryType { get; set; }
        [ForeignKey("FormatType")]
        public int? FormatTypeID { get; set; }
        public virtual FormatType FormatType { get; set; }
        [ForeignKey("Budget")]
        public int? BudgetsID { get; set; }
        public virtual Budget Budget { get; set; }


        [ForeignKey("Scope")]
        public int? ScopeID { get; set; }
        public virtual Scope Scope { get; set; }

        public int? PlanedTraineeNumber { get; set; }
        public float? EstimatedBudget { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public int? AcceptedTraineeNumber { get; set; }
        public int? ActualTraineeNumber { get; set; }
        [MaxLength(20)]
        public string Milestones { get; set; }
        [MaxLength(200)]
        public string Curriculum { get; set; }

        [Required]
        [MaxLength(200)]
        public string Status { get; set; }

       
        public string Remark { get; set; }
        
        public string History { get; set; }

        public virtual LearningPath LearningPath { get; set; }
        public virtual SupplierPartner SupplierPartner { get; set; }
        public virtual ICollection<Audit> Audit { get; set; }

        public virtual ICollection<Trainee> Trainees { get; set; }
















    }
}

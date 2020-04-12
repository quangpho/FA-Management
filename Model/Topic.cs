namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Topic")]
    public partial class Topic
    {
        [Key]
        public int TopicID { get; set; }
        [ForeignKey("MilestoneConfiguration")]
        public int MilestoneConfigurationId { get; set; }
        public double? TopicMark { get; set; }

        public int? LearningPathID { get; set; }

        [StringLength(250)]
        public string Remarks { get; set; }

        [StringLength(50)]
        public string TopicName { get; set; }
        [Required]
        public double MaxScore { get; set; }
        [Required]
        public double PassingScore { get; set; }
        [Required]
        public double WeightedNumber { get; set; }

        public virtual MilestoneConfiguration MilestoneConfiguration { get; set; }
    }
}

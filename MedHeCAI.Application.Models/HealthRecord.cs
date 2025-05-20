using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedHeCAI.Application.Models
{
    [Table("HealthRecord")]
    public class HealthRecord
    {
        [Key]
        public int HealthRecordId { get; set; }

        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }

        [Required]
        [ForeignKey("Disease")]
        public int DiseaseId { get; set; }

        public string AIRecommendations { get; set; }

        public DateTime? FollowUpDate { get; set; }

        public bool IsCritical { get; set; }  
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; } 
        public string Symptoms { get; set; }
        public virtual Disease Disease { get; set; }
        public virtual User User { get; set; }

    }
}

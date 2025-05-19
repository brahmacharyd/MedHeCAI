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

        [ForeignKey("Customer")]

        public int CustomerId { get; set; }



        [Required]

        [ForeignKey("Disease")]

        public int DiseaseId { get; set; }



        [Required]

        public DateTime DiagnosisDate { get; set; }



        public string AIRecommendations { get; set; }



        public string Notes { get; set; }



        public string TreatmentPlan { get; set; }



        public DateTime? FollowUpDate { get; set; }



        public bool IsCritical { get; set; }



        public string RecordedBy { get; set; }



        public bool IsActive { get; set; }



        public bool IsDeleted { get; set; }



        [Required]

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;



        public DateTime? UpdatedAt { get; set; }



        public string Status { get; set; }  // e.g., Active, Resolved, Monitoring 



        public string Symptoms { get; set; }



        // Navigation properties 

        //public virtual Customer Customer { get; set; }



        public virtual Disease Disease { get; set; }

    }
}

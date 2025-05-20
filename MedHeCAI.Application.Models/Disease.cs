using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedHeCAI.Application.Models
{
    [Table("Diseases")]
    public class Disease
    {
        [Key]
        public int DiseaseId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [MaxLength(1000)]
        public string? Description { get; set; }

        [MaxLength(500)]
        public string? Cause { get; set; }

        [MaxLength(500)]
        public string? Transmission { get; set; }

        [MaxLength(500)]
        public string? Prevention { get; set; }

        [MaxLength(500)]
        public string? Treatment { get; set; }
        public int AverageDurationDays { get; set; }

        [MaxLength(1000)]
        public string? Symptoms { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;

    }
}

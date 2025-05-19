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

        public string Name { get; set; } = null!;  // non-nullable with required 



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



        public bool IsContagious { get; set; }



        public int AverageDurationDays { get; set; }



        [MaxLength(1000)]

        public string? Symptoms { get; set; }  // comma-separated string 



        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;



        public DateTime? UpdatedAt { get; set; }



        [MaxLength(100)]

        public string? CreatedBy { get; set; }



        [MaxLength(100)]

        public string? UpdatedBy { get; set; }



        public bool IsActive { get; set; } = true;



        public bool IsDeleted { get; set; } = false;

    }
}

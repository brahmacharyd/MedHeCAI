using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedHeCAI.Application.Models
{
    public class DeviceLocation
    {
        [Key]
        public int DeviceLocationId { get; set; }

        [Required]
        [StringLength(100)]
        public string LocationName { get; set; }

        [Required]
        [StringLength(50)]
        public string Latitude { get; set; }

        [Required]
        [StringLength(50)]
        public string Longitude { get; set; }

        // Foreign key
        [ForeignKey("User")]
        public int UserId { get; set; }

        public virtual User User { get; set; }

        // Audit fields
        public bool IsActive { get; set; } = true;

        public bool IsDeleted { get; set; } = false;

        [Required]
        public DateTime LoginTime { get; set; } = DateTime.UtcNow;

        [Required]
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedOn { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedHeCAI.Application.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Patient
    {
        [Key]
        public int PatientId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required, MaxLength(20)]
        public string Gender { get; set; }

        [Phone]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required, MaxLength(50)]
        public string UserRelationship { get; set; }


        [MaxLength(200)]
        public string Address { get; set; }

        [MaxLength(5)]
        public string BloodGroup { get; set; }

        [MaxLength(500)]
        public string Allergies { get; set; }

        [MaxLength(500)]
        public string ChronicDiseases { get; set; }

        [MaxLength(100)]
        public string EmergencyContactName { get; set; }

        [Phone]
        [MaxLength(20)]
        public string EmergencyContactPhone { get; set; }

        public bool IsPhysicallyDisable { get; set; } = true;

        public bool IsActive { get; set; } = true;

        public bool IsDeleted { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }
    }

}

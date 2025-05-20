using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedHeCAI.Application.Models
{
    [Table("Medicines")]
    public class Medicine
    {
        [Key]
        public int MedicineId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [MaxLength(200)]
        public string Composition { get; set; }

        [MaxLength(100)]
        public DateTime ManufacturerDate { get; set; }

        [MaxLength(300)]
        public string SideEffects { get; set; }

        [MaxLength(300)]
        public string Precautions { get; set; }

        [MaxLength(20)]
        public string Power { get; set; }

        [MaxLength(50)]
        public string HowToUse { get; set; }        
        public DateTime? ExpiryDate { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        [MaxLength(50)]
        public string MadeIn { get; set; }
        public bool IsEmergencyMedicine { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedOn { get; set; }
    }
}

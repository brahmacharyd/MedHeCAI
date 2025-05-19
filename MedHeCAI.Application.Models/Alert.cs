using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace MedHeCAI.Application.Models
{
    public class Alert
    {
        [Key]

        public int MedicineAlertId { get; set; }



        [Required]

        public int MedicineId { get; set; }



        [Required]

        public int StoreId { get; set; }



        [Required]

        public DateTime AlertDate { get; set; }



        [Required]

        [MaxLength(100)]

        public string AlertType { get; set; }



        [Required]

        [MaxLength(500)]

        public string AlertMessage { get; set; }



        public bool IsActive { get; set; } = true;



        public bool IsDeleted { get; set; } = false;



        [Required]

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;



        public DateTime? UpdatedAt { get; set; }



        // Navigation Properties 

        [ForeignKey("MedicineId")]

        public virtual Medicine Medicine { get; set; }



        [ForeignKey("StoreId")]

        public virtual MedicalStore MedicalStore { get; set; }
    }
}

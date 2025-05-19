using System;

using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;


namespace MedHeCAI.Application.Modals
{   

    [Table("MedicalStores")]

    public class MedicalStore
    {
        [Key]
        public int StoreId { get; set; }

        [Required, MaxLength(100)]
        public string StoreName { get; set; }

        [MaxLength(100)]
        public string OwnerName { get; set; }

        [MaxLength(250)]

        public string Address { get; set; }

        [MaxLength(100)]

        public string MainArea { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        [MaxLength(10)]

        public string ContactNumber { get; set; }

        [MaxLength(100)]

        public string Email { get; set; }

        [MaxLength(500)]

        public string GoogleMapLink { get; set; }

        public DateTime EstablishedDate { get; set; }

        public bool HomeDeliveryAvailable { get; set; }

        [MaxLength(100)]

        public string WebsiteUrl { get; set; }

        public double Rating { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }



        // Navigation property 

        public virtual ICollection<VisitHistory> VisitHistory { get; set; }

    }

}

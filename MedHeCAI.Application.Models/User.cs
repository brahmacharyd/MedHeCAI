using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedHeCAI.Application.Models
{
    [Table("User")]
    [Microsoft.EntityFrameworkCore.Index(nameof(Email), IsUnique = true)]
    [Microsoft.EntityFrameworkCore.Index(nameof(UserName), IsUnique = true)]
    [Microsoft.EntityFrameworkCore.Index(nameof(PhoneNumber), IsUnique = true)]
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(10)]
        public string Gender { get; set; }

        [Required, MaxLength(100), EmailAddress]
        public string Email { get; set; }

        [Required, MaxLength(100)]
        public string UserName { get; set; }

        [Required, MaxLength(255)]
        public string Password { get; set; }

        // Phone Number: only digits, exactly 10 characters, and unique
        [Required, MaxLength(10), MinLength(10)]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must be exactly 10 digits.")]
        public string PhoneNumber { get; set; }

        public DateTime DateOfBirth { get; set; }

        public bool IsActive { get; set; } = true;

        public bool IsDeleted { get; set; } = false;

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedOn { get; set; }

        [MaxLength(100)]
        public string SignUpSource { get; set; }

        public DateTime? LastLoginDate { get; set; }

        public bool IsOnline { get; set; } = false;
    }
}

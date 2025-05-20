using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedHeCAI.Application.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> users { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<DeviceLocation> DeviceLocations { get; set; }
        public DbSet<MedicalStore> MedicalStores { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<HealthRecord> HealthRecords { get; set; }
        public DbSet<Alert> Alerts { get; set; }
    }
}

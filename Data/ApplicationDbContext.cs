using Microsoft.EntityFrameworkCore;
using SchoolProject.Models;

namespace SchoolProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<SalesData> SalesData {get; set;}
        public DbSet<NurseRequest> NurseRequests {get; set;}
        public DbSet<Patient> Patients {get; set; }
    }
}
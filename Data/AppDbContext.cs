using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmploymentVerification.Models;
using Microsoft.EntityFrameworkCore;

namespace EmploymentVerification.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 101, CompanyName = "Infosys", VerificationCode = "Infy123" },
                new Employee { Id = 102, CompanyName = "Wipro", VerificationCode = "Wip789" }
            );
        }
    }
}

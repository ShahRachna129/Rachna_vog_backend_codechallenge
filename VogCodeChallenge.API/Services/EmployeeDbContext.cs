using Microsoft.EntityFrameworkCore;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Services
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
        }
    }
}

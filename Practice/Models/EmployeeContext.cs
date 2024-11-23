using Microsoft.EntityFrameworkCore;
namespace Practice.Models

{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() { }

        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }

        public virtual DbSet<Employee> Employees { get; set; }
    }
}

using Demo.DataAccess.Models.DepartmentModule;
using Demo.DataAccess.Models.EmployeeModule;
using System.Security.Principal;

namespace Demo.DataAccess.Data.Contexts
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options) 
        { 
        
        } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

    }
}

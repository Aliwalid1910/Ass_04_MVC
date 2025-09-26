using Demo.DataAccess.Models.EmployeeModule;
using Demo.DataAccess.Models.Shared;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.DataAccess.Data.Configrations
{
    internal class EmployeeConfigration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(E => E.Address).HasColumnType("varchar(50)");
            builder.Property(E => E.Name).HasColumnType("varchar(50)");
            builder.Property(E => E.Salary).HasColumnType("decimal(10,2)");
            builder.Property(E => E.CreatedOn).HasDefaultValueSql("GETDATE()");
            builder.Property(E => E.ModifiedOn).HasComputedColumnSql("GETDATE()");
            builder.Property(E => E.Gender).HasConversion((empGender) => empGender.ToString(),
               (gender) => (Gender)Enum.Parse(typeof(Gender), gender));
            builder.Property(E => E.EmployeeType).HasConversion((empType) => empType.ToString(),
               (employeeType) => (EmployeeType)Enum.Parse(typeof(EmployeeType), employeeType));

        }
    }
}

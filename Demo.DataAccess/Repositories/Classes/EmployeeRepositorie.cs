using Demo.DataAccess.Data.Contexts;
using Demo.DataAccess.Models.DepartmentModule;
using Demo.DataAccess.Models.EmployeeModule;
using Demo.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Demo.DataAccess.Repositories.Classes
{
    internal class EmployeeRepositorie(ApplicationDbContext _dbContext):GenericRepositorie<Employee>(_dbContext) ,IEmployeeRepositorie
    {
    }
}

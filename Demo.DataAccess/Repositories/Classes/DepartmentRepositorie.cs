using Demo.DataAccess.Data.Contexts;
using Demo.DataAccess.Models.DepartmentModule;
using Demo.DataAccess.Repositories.Interfaces;

namespace Demo.DataAccess.Repositories.Classes
{
    public class DepartmentRepositorie(ApplicationDbContext _dbContext) : GenericRepositorie<Department>(_dbContext) ,IDepartmentRepositorie
    {

    }
}

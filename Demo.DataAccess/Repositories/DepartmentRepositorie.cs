using Demo.DataAccess.Data.Contexts;

namespace Demo.DataAccess.Repositories
{
    internal class DepartmentRepositorie(ApplicationDbContext _dbContext)
    {
        // Inside Scope                                                   
        // 5 CRUD OPERATIONS                                                           
        //GET ALL                                                       
        //GET BY ID

        public Department? GetById(int id)
        { 
            var department = _dbContext.Departments.Find(id);
            return department;
        }
        //ADD
        //UPDATE
        //RENAME


    }
}

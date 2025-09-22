using Demo.DataAccess.Data.Contexts;

namespace Demo.DataAccess.Repositories
{
    public class DepartmentRepositorie(ApplicationDbContext _dbContext) : IDepartmentRepositorie
    {
        // Inside Scope                                                   
        // 5 CRUD OPERATIONS                                                           
        //GET ALL                                                       
        public IEnumerable<Department> GetAll(bool WithTracking = false)
        {
            if (WithTracking)
                return _dbContext.Departments.ToList();
            else
                return _dbContext.Departments.AsNoTracking().ToList();
        }
        //GET BY ID
        public Department? GetById(int id) => _dbContext.Departments.Find(id);

        //ADD
        public int Add(Department department)
        {
            _dbContext.Departments.Add(department); // Add Locally
            return _dbContext.SaveChanges();  //num of Rows added
        }
        //UPDATE
        public int Update(Department department)
        {
            _dbContext.Departments.Update(department); // Update Locally
            return _dbContext.SaveChanges();  //num of Rows affected
        }
        //REMOVE
        public int Remove(Department department)
        {
            _dbContext.Departments.Remove(department); // Update Locally
            return _dbContext.SaveChanges();  //num of Rows Deleted
        }



    }
}

using Demo.DataAccess.Data.Contexts;
using Demo.DataAccess.Repositories;

namespace Demo.BusinessLogic.Services
{
    internal class DepartmentService
    {
        private readonly IDepartmentRepositorie _departmentRepositorie;

        public DepartmentService(DepartmentRepositorie departmentRepositorie)
        {
            _departmentRepositorie = departmentRepositorie;
        }
        public void Test(int id)
        {
            var Result = _departmentRepositorie.GetById(id);
        }
    }
}

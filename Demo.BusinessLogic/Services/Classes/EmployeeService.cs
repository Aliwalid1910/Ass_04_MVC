using Demo.BusinessLogic.DTOS.EmployeeDTOS;
using Demo.BusinessLogic.Services.Interfaces;
using Demo.DataAccess.Repositories.Interfaces;

namespace Demo.BusinessLogic.Services.Classes
{
    public class EmployeeService(IEmployeeRepositorie _employeeRepository) : IEmployeeService
    {
        public IEnumerable<EmployeeDto> GetAllEmployees(bool withTracking = false)
        {
           var employees = _employeeRepository.GetAll(withTracking);
            var employeesDto = employees.Select(E => new EmployeeDto()
            {
                Email = E.Email,
                Age = E.Age,
                Id = E.Id,
                Name = E.Name,
                Salary = E.Salary,
                IsActive = E.IsActive,
                Gender = E.Gender.ToString(),
                EmployeeType = E.EmployeeType.ToString(),

            });
            return employeesDto;

        }

        public EmployeeDetailsDto? GetEmployeeById(int id)
        {
            var employee = _employeeRepository.GetById(id);
            return employee is null ? null : new EmployeeDetailsDto()
            {
                Email = employee.Email,
                Age = employee.Age,
                Id = employee.Id,
                Name = employee.Name,
                Address = employee.Address,
                PhoneNumber = employee.PhoneNumber,
                IsActive = employee.IsActive,
                Salary = employee.Salary,
                HiringDate = DateOnly.FromDateTime(employee.HiringDate),
                CreatedOn = employee.CreatedOn,
                ModifiedOn = employee.ModifiedOn,
                ModifiedBy = 1,
                CreatedBy = 1,
                EmployeeType = employee.EmployeeType.ToString(),
                Gender = employee.Gender.ToString()
            };
            
        }

        public int CreateEmployee(CreateEmployeeDto employeeDto)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }


        public int UpdateEmployee(UpdatedEmployeeDto employeeDto)
        {
            throw new NotImplementedException();
        }
    }
}

using BlazorCrudProject.DataAccess.Entities;
using BlazorCrudProject.DataAccess.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlazorCrudProject.DataAccess.Services
{
    public class EmployeeService
    {
        private readonly ApplicationDbContext dbContext;

        public EmployeeService(ApplicationDbContext dbContext ) 
        {
            this.dbContext = dbContext;
        }

        public async Task<List<EmployeeViewModel>> GetAllEmployee()
        {
            return await dbContext.Employees
                .OrderBy(x => x.FullName)
                .Select(x => new EmployeeViewModel
                {
                    EmployeeId = x.EmployeeId,
                    FullName = x.FullName,
                    Department = x.Department,
                    DateOfBirth = x.DateOfBirth,
                    Age = x.Age,
                    PhoneNumber = x.PhoneNumber,
                }).ToListAsync();
        }

        public bool CreateEmployee(EmployeeViewModel employee)
        {
            try
            {
                Employee employees = new Employee
                {
                    FullName = employee.FullName,
                    Department = employee.Department,
                    DateOfBirth = employee.DateOfBirth,
                    Age = employee.Age,
                    PhoneNumber = employee.PhoneNumber,
                };

                dbContext.Employees.Add( employees );
                var result = dbContext.SaveChanges();

                return result > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}

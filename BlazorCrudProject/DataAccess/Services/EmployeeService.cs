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

        public EmployeeViewModel? FindEmployee(int employeeId)
        {
            var employee = dbContext.Employees.Find(employeeId);
            if (employee == null) return null;

            EmployeeViewModel result = new EmployeeViewModel
            {
                EmployeeId = employee.EmployeeId,
                FullName = employee.FullName,
                Department = employee.Department,
                DateOfBirth = employee.DateOfBirth,
                Age = employee.Age,
                PhoneNumber = employee.PhoneNumber,
            };

            return result;
        }

        public bool UpdateEmployee(EmployeeViewModel model)
        {
            try
            {
                var employee = dbContext.Employees.Find(model.EmployeeId);
                if (employee == null) return false;

                employee.FullName = model.FullName;
                employee.Department = model.Department;
                employee.DateOfBirth = model.DateOfBirth;
                employee.Age = model.Age;
                employee.PhoneNumber = model.PhoneNumber;

                var result = dbContext.SaveChanges();
                return (result > 0);
            }
            catch (Exception ex)
            {
                return false;
            }
           
        }

        public bool DeleteEmployee(int employeeId)
        {
            try
            {
                var employee = dbContext.Employees.Find(employeeId);
                if (employee == null) return false;

                dbContext.Employees.Remove(employee);
                var result = dbContext.SaveChanges();
                return (result > 0);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

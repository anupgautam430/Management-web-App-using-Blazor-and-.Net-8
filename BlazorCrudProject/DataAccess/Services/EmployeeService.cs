using BlazorCrudProject.DataAccess.ViewModels;
using Microsoft.EntityFrameworkCore;

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
    }
}

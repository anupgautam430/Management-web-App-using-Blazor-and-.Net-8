using BlazorCrudProject.DataAccess.Entities;
using BlazorCrudProject.DataAccess.ViewModels;
using ClosedXML.Excel;
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

        public async Task<bool> ImportEmployee(List<EmployeeViewModel>employees)
        {
            try
            {
                List<Employee> toDb = new List<Employee>();
                foreach (var employee in employees)
                {
                    Employee employee1 = new Employee
                    {
                        FullName = employee.FullName,
                        Department = employee.Department,
                        DateOfBirth = employee.DateOfBirth,
                        Age = employee.Age,
                        PhoneNumber = employee.PhoneNumber,
                    };
                    toDb.Add(employee1);
                }
                await dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public async Task<Byte[]> ExportToExcel()
        {
            var datas = await GetAllEmployee();

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Employee");

                worksheet.Cell(1, 1).Value = "Employee Id";
                worksheet.Cell(2, 1).Value = "Full Name";
                worksheet.Cell(1, 3).Value = "Department";
                worksheet.Cell(1, 4).Value = "Date Of Birth";
                worksheet.Cell(1, 5).Value = "Age";
                worksheet.Cell(1, 6).Value = "Phone Number";

                for (int i = 0; i < datas.Count; i++)
                {
                    worksheet.Cell(i + 2, 1).Value = datas[i].EmployeeIdView;
                    worksheet.Cell(i + 2, 2).Value = datas[i].FullName;
                    worksheet.Cell(i + 2, 3).Value = datas[i].Department;
                    worksheet.Cell(i + 2, 4).Value = datas[i].DateOfBirth;
                    worksheet.Cell(i + 2, 5).Value = datas[i].Age;
                    worksheet.Cell(i + 2, 6).Value = datas[i].PhoneNumber;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    return stream.ToArray();
                }
            }
        }
    }
}

using BlazorCrudProject.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudProject.DataAccess
{
    public static class Seed 
    {
        public static void GenerateSeed(this ModelBuilder modelBuilder)
        {
            var employees = new[]
            {
                new Employee { EmployeeId = 1, FullName = "John Moxley", Department = "Sales", DateOfBirth = new DateTime(1985, 5, 10), Age = 39, PhoneNumber = 98632540 },
                new Employee { EmployeeId = 2, FullName = "Sarah Smith", Department = "Marketing", DateOfBirth = new DateTime(1990, 8, 15), Age = 34, PhoneNumber = 98632540 },
                new Employee { EmployeeId = 3, FullName = "Michael Johnson", Department = "HR", DateOfBirth = new DateTime(1988, 3, 20), Age = 36, PhoneNumber = 98632540 },
                new Employee { EmployeeId = 4, FullName = "Emily Davis", Department = "Finance", DateOfBirth = new DateTime(1995, 11, 5), Age = 29, PhoneNumber = 98632540 },
                new Employee { EmployeeId = 5, FullName = "David Wilson", Department = "IT", DateOfBirth = new DateTime(1992, 1, 12), Age = 32, PhoneNumber = 98632540 },
                new Employee { EmployeeId = 6, FullName = "Linda Martinez", Department = "Operations", DateOfBirth = new DateTime(1987, 6, 18), Age = 37, PhoneNumber = 98632540 },
                new Employee { EmployeeId = 7, FullName = "James Brown", Department = "Logistics", DateOfBirth = new DateTime(1993, 7, 22), Age = 31, PhoneNumber = 98632540 },
                new Employee { EmployeeId = 8, FullName = "Olivia Taylor", Department = "Support", DateOfBirth = new DateTime(1991, 2, 14), Age = 33, PhoneNumber = 98632540 },
                new Employee { EmployeeId = 9, FullName = "William Harris", Department = "R&D", DateOfBirth = new DateTime(1986, 12, 30), Age = 38, PhoneNumber = 98632540 },
                new Employee { EmployeeId = 10, FullName = "Sophia Anderson", Department = "Sales", DateOfBirth = new DateTime(1994, 4, 3), Age = 30, PhoneNumber = 98632540},
                new Employee { EmployeeId = 11, FullName = "Benjamin Clark", Department = "Marketing", DateOfBirth = new DateTime(1989, 9, 27), Age = 35, PhoneNumber = 98632540 },
                new Employee { EmployeeId = 12, FullName = "Mia Lewis", Department = "HR", DateOfBirth = new DateTime(1997, 5, 21), Age = 27, PhoneNumber = 98632540 },
                new Employee { EmployeeId = 13, FullName = "Alexander Lee", Department = "IT", DateOfBirth = new DateTime(1984, 10, 13), Age = 40, PhoneNumber = 98632540 },
                new Employee { EmployeeId = 14, FullName = "Isabella Walker", Department = "Finance", DateOfBirth = new DateTime(1996, 3, 9), Age = 28, PhoneNumber = 98632540 },
                new Employee { EmployeeId = 15, FullName = "Henry Hall", Department = "Operations", DateOfBirth = new DateTime(1983, 8, 1), Age = 41, PhoneNumber = 98632545 },
                new Employee { EmployeeId = 16, FullName = "Charlotte Young", Department = "Support", DateOfBirth = new DateTime(1998, 12, 25), Age = 26, PhoneNumber = 98632540 }
            };

            foreach (var employee in employees) 
            {
                modelBuilder.Entity<Employee>().HasData(employee);
            }
        }
    }
}

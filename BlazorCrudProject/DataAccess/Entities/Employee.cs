﻿namespace BlazorCrudProject.DataAccess.Entities
{
    public class Employee
    {

        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string Department { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public int PhoneNumber { get; set; }
    }
}

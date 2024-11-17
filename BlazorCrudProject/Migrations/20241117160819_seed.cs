using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorCrudProject.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "DateOfBirth", "Department", "FullName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, 39, new DateTime(1985, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "John Moxley", 98632540 },
                    { 2, 34, new DateTime(1990, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Sarah Smith", 98632540 },
                    { 3, 36, new DateTime(1988, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Michael Johnson", 98632540 },
                    { 4, 29, new DateTime(1995, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Emily Davis", 98632540 },
                    { 5, 32, new DateTime(1992, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "David Wilson", 98632540 },
                    { 6, 37, new DateTime(1987, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Linda Martinez", 98632540 },
                    { 7, 31, new DateTime(1993, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Logistics", "James Brown", 98632540 },
                    { 8, 33, new DateTime(1991, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Support", "Olivia Taylor", 98632540 },
                    { 9, 38, new DateTime(1986, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "R&D", "William Harris", 98632540 },
                    { 10, 30, new DateTime(1994, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Sophia Anderson", 98632540 },
                    { 11, 35, new DateTime(1989, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Benjamin Clark", 98632540 },
                    { 12, 27, new DateTime(1997, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Mia Lewis", 98632540 },
                    { 13, 40, new DateTime(1984, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Alexander Lee", 98632540 },
                    { 14, 28, new DateTime(1996, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Isabella Walker", 98632540 },
                    { 15, 41, new DateTime(1983, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Henry Hall", 98632545 },
                    { 16, 26, new DateTime(1998, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Support", "Charlotte Young", 98632540 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 16);
        }
    }
}

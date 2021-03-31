using System.Collections.Generic;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Services
{
    public static class SeedData
    {
        public static void FetchSeedData(IDataService dataService)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { EmpId = 1, EmpFirstName = "Rachna", EmpLastName = "Shah", EmpAddress = "123Abc", Department = new Department() { DeptCode = 1, DeptAddress = "ABC123", DeptName = "IT" }, EmpJobTitle = "Agile Developer" });
            employees.Add(new Employee() { EmpId = 2, EmpFirstName = "Shreya", EmpLastName = "Doshi", EmpAddress = "345PQR", Department = new Department() { DeptCode = 2, DeptAddress = "PQR234", DeptName = "HR" }, EmpJobTitle = "HR Manager" });
            employees.Add(new Employee() { EmpId = 3, EmpFirstName = "Meet", EmpLastName = "Doshi", EmpAddress = "678FGH", Department = new Department() { DeptCode = 2, DeptAddress = "PQR234", DeptName = "HR" }, EmpJobTitle = "Paython Developer" });
            employees.Add(new Employee() { EmpId = 4, EmpFirstName = "Rebecca", EmpLastName = "Messa", EmpAddress = "897RHT", Department = new Department() { DeptCode = 4, DeptAddress = "EFG189", DeptName = "QA" }, EmpJobTitle = "QA Tester" });

            List<Department> departments = new List<Department>();
            departments.Add(new Department() { DeptCode = 1, DeptAddress = "ABC123", DeptName = "IT"  });
            departments.Add(new Department() { DeptCode = 2, DeptAddress = "PQR234", DeptName = "HR"});
            departments.Add(new Department() { DeptCode = 3, DeptAddress = "STD126", DeptName = "Finance" });
            departments.Add(new Department() { DeptCode = 4, DeptAddress = "EFG189", DeptName = "QA" });

            dataService.SettingDataForEmployee(employees);
            dataService.SettingDataForDepartments(departments);
        }
    }
}

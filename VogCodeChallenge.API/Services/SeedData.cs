using System;
using System.Collections.Generic;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Services
{
    public static class SeedData
    {
        public static void FetchSeedData(IDataService dataService)
        {
            List<Employee> lstEmployee = new List<Employee>();
            lstEmployee.Add(new Employee() { EmpId = 1, EmpFirstName = "Rachna", EmpLastName = "Shah", EmpAddress = "123Abc", EmpDept = new Department() { DeptCode = 1, DeptAddress = "ABC123", DeptName = "IT" }, EmpJobTitle = "Agile Developer" });
            lstEmployee.Add(new Employee() { EmpId = 2, EmpFirstName = "Shreya", EmpLastName = "Doshi", EmpAddress = "345PQR", EmpDept = new Department() { DeptCode = 2, DeptAddress = "PQR234", DeptName = "HR" }, EmpJobTitle = "HR Manager" });
            lstEmployee.Add(new Employee() { EmpId = 3, EmpFirstName = "Meet", EmpLastName = "Doshi", EmpAddress = "678FGH", EmpDept = new Department() { DeptCode = 2, DeptAddress = "PQR234", DeptName = "HR" }, EmpJobTitle = "Paython Developer" });
            lstEmployee.Add(new Employee() { EmpId = 4, EmpFirstName = "Rebecca", EmpLastName = "Messa", EmpAddress = "897RHT", EmpDept = new Department() { DeptCode = 4, DeptAddress = "EFG189", DeptName = "QA" }, EmpJobTitle = "QA Tester" });

            List<Department> lstDepartment = new List<Department>();
            lstDepartment.Add(new Department() { DeptCode = 1, DeptAddress = "ABC123", DeptName = "IT" });
            lstDepartment.Add(new Department() { DeptCode = 2, DeptAddress = "PQR234", DeptName = "HR" });
            lstDepartment.Add(new Department() { DeptCode = 3, DeptAddress = "STD126", DeptName = "Finance" });
            lstDepartment.Add(new Department() { DeptCode = 4, DeptAddress = "EFG189", DeptName = "QA" });

            dataService.SettingDataForEmployee(lstEmployee);
            dataService.SettingDataForDepartments(lstDepartment);
        }
    }
}

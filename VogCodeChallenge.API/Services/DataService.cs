using System.Collections.Generic;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Services
{
    public class DataService :IDataService
    {
        private List<Department> departments;
        private List<Employee> employees;
        
        public IEnumerable<Employee> GetAll()
        {
            return employees;
        }

        public IList<Employee> ListAll()
        {
            return employees;
        }
        public Employee GetEmpById(int empid)
        {
            return employees.Find(x => x.EmpId.Equals(empid));
        }

        public Department GetEmpByDept(int deptid)
        {
           Department dept = departments.Find(x => x.DeptCode.Equals(deptid));

            return dept != null ? dept : null;
        }
        public void SettingDataForEmployee(List<Employee> lstEmployees) { this.employees = lstEmployees; }
        public void SettingDataForDepartments(List<Department> lstDepartments) { this.departments = lstDepartments; }
    }
}

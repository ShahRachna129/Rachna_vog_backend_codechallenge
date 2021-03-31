using System.Collections.Generic;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Services
{
    public interface IDataService
    {
        IEnumerable<Employee> GetAll();
        IList<Employee> ListAll();
        Employee GetEmpById(int empId);
       Department GetEmpByDept(int deptId);

       void SettingDataForEmployee(List<Employee> employees);
       void SettingDataForDepartments(List<Department> departments);
    }
}

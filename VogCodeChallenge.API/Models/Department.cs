using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Models
{
    public class Department
    {
        public int DeptCode { get; set; }
        public string DeptName { get; set; }
        public string DeptAddress { get; set; }

        public List<Employee> DepartmentWiseEmployees { get; set; }
    }
}

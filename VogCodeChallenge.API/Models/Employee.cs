using System.ComponentModel.DataAnnotations.Schema;
namespace VogCodeChallenge.API.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }
        public string EmpJobTitle { get; set; }
        public string EmpAddress { get; set; }
        [ForeignKey("DeptCode")]
        public Department Department { get; set; }
    }
}

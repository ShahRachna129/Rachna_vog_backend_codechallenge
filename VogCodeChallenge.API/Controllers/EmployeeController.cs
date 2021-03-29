using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VogCodeChallenge.API.Models;
using VogCodeChallenge.API.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VogCodeChallenge.API.Controllers
{
    [Route("api/[controller]")]
   
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IDataService _dataservice;
        public EmployeeController(IDataService dataService)
        {
            _dataservice = dataService;
            SeedData.FetchSeedData(_dataservice);
        }

        // GET api/employee
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetAll()
        {
            var records = _dataservice.GetAll();
            if (records != null)
                return Ok(records);
            return NotFound();
        }
        // GET api/<EmployeeController>/5
        [HttpGet("{id}",Name = "GetEmpById")]
        public ActionResult<Employee> GetEmpById(int id)
        {
            var data = _dataservice.GetEmpById(id);
            if (data != null)
                return Ok(data);
            return NotFound();
        }

        // GET api/employee/department/1
        [Route("/deparment/{departmentId}")]
        [HttpGet]

        public ActionResult<IEnumerable<Employee>> Deparment(int departmentId)
        {
            var data = _dataservice.GetEmpByDept(departmentId);
            if (data != null)
                return Ok(data);
            return NotFound();
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

using Employees.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAPI.Controllers
{
    /// <summary>
    /// HumanResources Controller
    /// </summary>
    [Route("api/v1/manager")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        /// <summary>
        /// Manager salary :double  and bonus : double 
        /// </summary>
        /// <returns>salary value</returns>
        [HttpGet("calculate-salary")]
        public double CalculateSalary([FromQuery] double salary, [FromQuery] double bonus)
        {
            var manager = new Manager("Zack", salary,bonus);
            return manager.Salary;
        }
    }
}

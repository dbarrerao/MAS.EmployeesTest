using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MAS.BusinessLogic.Interfaces;
using MAS.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MAS.EmployeesTest.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private IEmployeeBusinessLogic _employeeBusinessLogic;

        public EmployeeController(IEmployeeBusinessLogic employeeBusinessLogic)
        {
            _employeeBusinessLogic = employeeBusinessLogic;
        }

        /// <summary>
        /// Get list with all employees
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await _employeeBusinessLogic.GetAllEmployees();
        }

        /// <summary>
        /// Get an employee from the ID
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        [HttpGet("{employeeId}")]
        public async Task<Employee> GetEmployeeById(int employeeId)
        {
            return await _employeeBusinessLogic.GetEmployeeById(employeeId);
        }
    }
}

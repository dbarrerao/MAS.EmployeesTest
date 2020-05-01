﻿using System;
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

        // GET: api/<controller>
        [HttpGet]
        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await _employeeBusinessLogic.GetAllEmployees();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
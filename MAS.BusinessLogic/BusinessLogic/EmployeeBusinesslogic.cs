﻿using MAS.BusinessLogic.Factories;
using MAS.BusinessLogic.Interfaces;
using MAS.Models;
using MAS.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MAS.BusinessLogic.BusinessLogic
{
    public class EmployeeBusinesslogic : IEmployeeBusinessLogic
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeeBusinesslogic(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        /// <summary>
        /// Method that return List with all employees.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Employee>> GetAllEmployees()
        {
            var employeesList =  await _employeeRepository.GetAllEmployees();

            foreach (var employee in employeesList)
            {
                EmployeeFactory.GetAnualSalarybyEmployee(employee);
            }

            return employeesList;
        }

        /// <summary>
        /// Get an employee from the ID.
        /// </summary>
        /// <param name="employeeId">identification of employee</param>
        /// <returns></returns>
        public async Task<Employee> GetEmployeeById(int employeeId)
        {
            var employee = await _employeeRepository.GetEmployeeById(employeeId);
            EmployeeFactory.GetAnualSalarybyEmployee(employee);

            return employee;
        }
    }
}

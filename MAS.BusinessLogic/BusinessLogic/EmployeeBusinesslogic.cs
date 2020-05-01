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
        async Task<List<Employee>> IEmployeeBusinessLogic.GetAllEmployees()
        {
            return await _employeeRepository.GetAllEmployees();
        }
    }
}

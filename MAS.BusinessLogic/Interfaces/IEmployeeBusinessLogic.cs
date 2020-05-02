using MAS.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MAS.BusinessLogic.Interfaces
{
    public interface IEmployeeBusinessLogic
    {
        Task<List<Employee>> GetAllEmployees();
        Task<Employee> GetEmployeeById(int employeeId);
    }
}

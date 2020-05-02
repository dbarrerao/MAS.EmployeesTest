using MAS.Models;
using MAS.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MAS.BusinessLogic.Interfaces
{
    public interface IEmployeeBusinessLogic
    {
        Task<List<ViewModelEmployee>> GetAllEmployees();
        Task<ViewModelEmployee> GetEmployeeById(int employeeId);
    }
}

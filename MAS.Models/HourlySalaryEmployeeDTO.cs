using MAS.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAS.Models
{
    public class HourlySalaryEmployeeDTO : ViewModelEmployee
    {
        public override decimal AnnualSalary { get { return 120 * HourlySalary * 12; } }
    
    }
}

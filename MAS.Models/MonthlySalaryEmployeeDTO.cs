using MAS.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAS.Models
{
    public class MonthlySalaryEmployeeDTO : ViewModelEmployee
    {
        public override decimal AnnualSalary { get { return MonthlySalary * 12; } }
    }
}

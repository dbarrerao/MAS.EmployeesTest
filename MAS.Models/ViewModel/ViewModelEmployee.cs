using System;
using System.Collections.Generic;
using System.Text;

namespace MAS.Models.ViewModel
{
    public abstract class ViewModelEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContractTypeName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public decimal HourlySalary { get; set; }
        public decimal MonthlySalary { get; set; }
        public abstract decimal AnnualSalary { get;}
    }
}

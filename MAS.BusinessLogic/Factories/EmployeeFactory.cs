using MAS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAS.BusinessLogic.Factories
{
    internal static class EmployeeFactory
    {
        /// <summary>
        /// Calculate the Anual Salary an employee depending the type of contract.
        /// </summary>
        /// <param name="employee">Employee object</param>
        /// <returns></returns>
        internal static Employee GetAnualSalarybyEmployee(Employee employee)
        {
            switch (employee.ContractTypeName)
            {
                case nameof(ContractTypeNameEnum.ContractTypeName.HourlySalaryEmployee):
                    employee.AnualSalary = 120 * employee.HourlySalary * 12;
                    break;
                case nameof(ContractTypeNameEnum.ContractTypeName.MonthlySalaryEmployee):
                    employee.AnualSalary = employee.MonthlySalary * 12;
                    break;
            }

            return employee;
        }
    }
}

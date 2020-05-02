using AutoMapper;
using MAS.Models;
using MAS.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAS.BusinessLogic.Factories
{
    internal static class EmployeeFactory 
    {
        private static IMapper _mapper;
        private static IMapper Mapper
        {
            get
            {
                if (_mapper == null)
                {
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<Employee, HourlySalaryEmployeeDTO>();
                        cfg.CreateMap<Employee, MonthlySalaryEmployeeDTO>();
                    });
                    _mapper = config.CreateMapper();
                }
                return _mapper;
            }
        }
               
        /// Calculate the Anual Salary an employee depending the type of contract.
        /// </summary>
        /// <param name="employee">Employee object</param>
        /// <returns></returns>
        internal static ViewModelEmployee GetAnualSalarybyEmployee(Employee employee)
        {
            ViewModelEmployee viewModelEmployee;

            switch (employee.ContractTypeName)
            {
                case nameof(ContractTypeNameEnum.ContractTypeName.HourlySalaryEmployee):
                    viewModelEmployee = Mapper.Map<Employee, HourlySalaryEmployeeDTO>(employee);
                    break;
                case nameof(ContractTypeNameEnum.ContractTypeName.MonthlySalaryEmployee):
                    viewModelEmployee = Mapper.Map<Employee, MonthlySalaryEmployeeDTO>(employee);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return viewModelEmployee;
        }
    }
}

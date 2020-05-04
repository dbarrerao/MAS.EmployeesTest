using MAS.BusinessLogic.BusinessLogic;
using MAS.BusinessLogic.Interfaces;
using MAS.Models;
using MAS.Models.ViewModel;
using MAS.Repositories.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading.Tasks;

namespace MAS.Test
{
    [TestClass]
    public class EmployeeBusinessTest
    {
        private IEmployeeBusinessLogic _employeeBusinessLogic;

        [TestInitialize]
        public void TestInitialize() 
        {
            var employeeRepositoryMock = new Mock<IEmployeeRepository>();

            var employeeSebastian = new Employee();

            employeeSebastian.Id = 2;
            employeeSebastian.Name = "Sebastian";
            employeeSebastian.ContractTypeName = "MonthlySalaryEmployee";
            employeeSebastian.RoleId = 2;
            employeeSebastian.RoleName = "Contractor";
            employeeSebastian.RoleDescription = null;
            employeeSebastian.HourlySalary = 60000;
            employeeSebastian.MonthlySalary = 80000;

            var employeeJuan = new Employee();

            employeeJuan.Id = 1;
            employeeJuan.Name = "Juan";
            employeeJuan.ContractTypeName = "HourlySalaryEmployee";
            employeeJuan.RoleId = 1;
            employeeJuan.RoleName = "Administrator";
            employeeJuan.RoleDescription = null;
            employeeJuan.HourlySalary = 60000;
            employeeJuan.MonthlySalary = 80000;


            employeeRepositoryMock.Setup(x => x.GetEmployeeById(2)).Returns(Task.FromResult(employeeSebastian));
            employeeRepositoryMock.Setup(x => x.GetEmployeeById(1)).Returns(Task.FromResult(employeeJuan));

            _employeeBusinessLogic = new EmployeeBusinesslogic(employeeRepositoryMock.Object);
        }
        
        [TestMethod]
        public async Task GetEmployeeById_AnnualSalary_correct_to_MonthlyContract()
        {
            int employeeId = 2;

            MonthlySalaryEmployeeDTO employee = new MonthlySalaryEmployeeDTO();

            employee.Id = employeeId;
            employee.Name = "Sebastian";
            employee.ContractTypeName = "MonthlySalaryEmployee";
            employee.RoleId = 2;
            employee.RoleName = "Contractor";
            employee.RoleDescription = null;
            employee.HourlySalary = 60000;
            employee.MonthlySalary = 80000;

            var annualSalaryHourly = employee.MonthlySalary * 12;

            var employeeInfo = await _employeeBusinessLogic.GetEmployeeById(employeeId);

            Assert.IsNotNull(employeeInfo);
            Assert.AreEqual(annualSalaryHourly, employeeInfo.AnnualSalary);
        }

        [TestMethod]
        public async Task GetEmployeeById_AnnualSalary_correct_to_HourlyContract()
        {
            int employeeId = 1;

            HourlySalaryEmployeeDTO employeeJuan = new HourlySalaryEmployeeDTO();

            employeeJuan.Id = employeeId;
            employeeJuan.Name = "Juan";
            employeeJuan.ContractTypeName = "HourlySalaryEmployee";
            employeeJuan.RoleId = 1;
            employeeJuan.RoleName = "Administrator";
            employeeJuan.RoleDescription = null;
            employeeJuan.HourlySalary = 60000;
            employeeJuan.MonthlySalary = 80000;

            var annualSalaryHourly = 120 * employeeJuan.HourlySalary * 12;

            var employeeInfo = await _employeeBusinessLogic.GetEmployeeById(employeeId);

            Assert.IsNotNull(employeeInfo);
            Assert.AreEqual(annualSalaryHourly, employeeInfo.AnnualSalary);
        }
    }
}

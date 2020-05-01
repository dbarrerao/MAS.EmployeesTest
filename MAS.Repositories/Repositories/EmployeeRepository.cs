using MAS.Models;
using MAS.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MAS.Repositories.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private IConfiguration _configuration;
        private readonly HttpClient HttpClient;
        HttpResponseMessage _response;

        public EmployeeRepository(IConfiguration configuration)
        {
            _configuration = configuration;

            HttpClient = new HttpClient()
            {
                BaseAddress = new Uri(_configuration.GetSection("ConectionString:EmployeesAPi").Value.ToString())
            };
        }

        /// <summary>
        /// Method that return List with all employees.
        /// </summary>
        /// <returns></returns>
        async Task<List<Employee>> IEmployeeRepository.GetAllEmployees()
        {
            _response = await HttpClient.GetAsync("Employees");
            var result = await _response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Employee>>(result);
        }

    }
}



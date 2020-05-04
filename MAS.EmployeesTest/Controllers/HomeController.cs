using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MAS.EmployeesTest.Models;

namespace MAS.EmployeesTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Employee()
        {
            return View();
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Technical Test for MASGlobal Consulting.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Diego Alejandro Barrera Ocampo";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

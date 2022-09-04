using EmployeesWeb.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationContext context;

        public HomeController(ApplicationContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index()
        {
            var employees = await context.Employees
                .Include(x => x.Address)
                .Include(x => x.Department)
                .Include(x => x.Position)
                .Include(x => x.Rating)
                .ToListAsync();

            return View(employees);
        }
    }
}

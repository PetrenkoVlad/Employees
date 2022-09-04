using EmployeesWeb.Data;
using EmployeesWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public async Task<IActionResult> Index([FromQuery]int department)
        {
            //Получаем всех сотрудников
            IQueryable<Employee> employees = context.Employees
                .Include(x => x.Address)
                .Include(x => x.Department)
                .Include(x => x.Position)
                .Include(x => x.Rating);
            //Если передали уникальный идентификатор отдела - отбираем сотрудников, которые работают в этом отделе, иначе показываем всех сотрудников
            if(department != 0)
            {
                employees = employees.Where(x => x.DepartmentId == department);
            }
            //Создаем список отделов для заполнения селектора
            var departmentsList = await context.Departments.ToListAsync();
            departmentsList.Insert(0, new Department { Id = 0, DepartmentName = "Все" });
            //Создаем модель представления и передаем её в представление
            var model = new HomeIndexViewModel
            {
                Employees = await employees.ToListAsync(),
                Departments = new SelectList(departmentsList, nameof(Department.Id), nameof(Department.DepartmentName))
            };
            return View(model);
        }
    }
}

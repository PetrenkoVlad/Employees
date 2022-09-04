using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesWeb.Models
{
    /// <summary>
    /// Модель представления для метода Index контроллера Home
    /// </summary>
    public class HomeIndexViewModel
    {
        /// <summary>
        /// Список сотрудников
        /// </summary>
        public IEnumerable<Employee> Employees { get; set; }

        /// <summary>
        /// Список отделов
        /// </summary>
        public SelectList Departments { get; set; }
    }
}

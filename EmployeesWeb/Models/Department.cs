using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesWeb.Models
{
    /// <summary>
    /// Отдел
    /// </summary>
    public class Department
    {
        /// <summary>
        /// Уникальный идентификатор отдела
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название отдела
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        /// Навигационное свойство на сотрудников
        /// </summary>
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}

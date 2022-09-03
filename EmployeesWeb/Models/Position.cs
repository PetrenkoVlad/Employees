using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesWeb.Models
{
    /// <summary>
    /// Должность
    /// </summary>
    public class Position
    {
        /// <summary>
        /// Уникальный идентификатор должности
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название должности
        /// </summary>
        public string PositionName { get; set; }

        /// <summary>
        /// Навигационное свойство на сотрудников
        /// </summary>
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}

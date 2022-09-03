using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesWeb.Models
{
    /// <summary>
    /// Оценка сотудника. На основе оценки вычисляется премия
    /// </summary>
    public class Rating
    {
        /// <summary>
        /// Оценка
        /// </summary>
        public string Mark { get; set; }

        /// <summary>
        /// Процент от зарплаты - премия
        /// </summary>
        public int Percent { get; set; }

        /// <summary>
        /// Навигационное свойство на сотрудников
        /// </summary>
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}

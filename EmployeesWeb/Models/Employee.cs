using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesWeb.Models
{
    /// <summary>
    /// Сотрудник
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Уникальный идентификатор сотрудника
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Телефонный номер
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Уникальный идентификатор адреса
        /// </summary>
        public int AddressId { get; set; }

        /// <summary>
        /// Навигационное свойство на адрес (связь один к одному)
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Уникальный идентификатор отдела
        /// </summary>
        public int DepartmentId { get; set; }

        /// <summary>
        /// Навигационное свойство на отдел (связь один ко многим)
        /// </summary>
        public Department Department { get; set; }

        /// <summary>
        /// Уникальный идентификатор должности
        /// </summary>
        public int PositionId { get; set; }

        /// <summary>
        /// Навигационное свойство на должность (связь один ко многим)
        /// </summary>
        public Position Position { get; set; }

        /// <summary>
        /// Зарплата
        /// </summary>
        public decimal Salary { get; set; }

        /// <summary>
        /// Уникальный идентификатор оценки
        /// </summary>
        public string RatingMark { get; set; }

        /// <summary>
        /// Навигационное свойство на оценку (связь один ко многим)
        /// </summary>
        public Rating Rating { get; set; }
    }
}

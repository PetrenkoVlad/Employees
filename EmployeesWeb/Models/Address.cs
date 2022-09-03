using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesWeb.Models
{
    /// <summary>
    /// Адрес
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Уникальный идентификатор адреса
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Населенный пункт
        /// </summary>
        public string LocalityName { get; set; }

        /// <summary>
        /// Улица
        /// </summary>
        public string StreetName { get; set; }

        /// <summary>
        /// Номер дома
        /// </summary>
        public string HouseNumber { get; set; }

        /// <summary>
        /// Номер квартиры
        /// </summary>
        public int? ApartmentNumber { get; set; }

        /// <summary>
        /// Навигационное свойство на сотрудника
        /// </summary>
        public Employee Employee { get; set; }
    }
}

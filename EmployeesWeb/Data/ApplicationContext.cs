using EmployeesWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesWeb.Data
{
    public class ApplicationContext : DbContext
    {
        /// <summary>
        /// Таблица адресов
        /// </summary>
        public DbSet<Address> Addresses { get; set; }

        /// <summary>
        /// Таблица отделов
        /// </summary>
        public DbSet<Department> Departments { get; set; }

        /// <summary>
        /// Таблица должностей
        /// </summary>
        public DbSet<Position> Positions { get; set; }

        /// <summary>
        /// Таблица оценок
        /// </summary>
        public DbSet<Rating> Ratings { get; set; }

        /// <summary>
        /// Таблица сотрудников
        /// </summary>
        public DbSet<Employee> Employees { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>().Property(p => p.LocalityName).IsRequired();
            modelBuilder.Entity<Address>().Property(p => p.StreetName).IsRequired();
            modelBuilder.Entity<Address>().Property(p => p.HouseNumber).IsRequired();
            
            modelBuilder.Entity<Department>().Property(p => p.DepartmentName).IsRequired();
            
            modelBuilder.Entity<Position>().Property(p => p.PositionName).IsRequired();
            
            modelBuilder.Entity<Rating>().HasKey(p => p.Mark);
            
            modelBuilder.Entity<Employee>().Property(p => p.LastName).IsRequired();
            modelBuilder.Entity<Employee>().Property(p => p.FirstName).IsRequired();
            modelBuilder.Entity<Employee>().Property(p => p.PhoneNumber).IsRequired();
            modelBuilder.Entity<Employee>().Property(p => p.RatingMark).IsRequired();

            fillDatabaseWithDefaultValues(modelBuilder);
        }

        //Заполнить базу данных начальными значениями
        private void fillDatabaseWithDefaultValues(ModelBuilder modelBuilder)
        {
            var address1 = new Address
            {
                Id = 1,
                LocalityName = "Киев",
                StreetName = "Маяковского",
                HouseNumber = "12",
                ApartmentNumber = 45
            };
            var address2 = new Address
            {
                Id = 2,
                LocalityName = "Одесса",
                StreetName = "Сабурова",
                HouseNumber = "75А",
                ApartmentNumber = 10
            };

            var department1 = new Department
            {
                Id = 1,
                DepartmentName = "Разработка ПО"
            };
            var department2 = new Department
            {
                Id = 2,
                DepartmentName = "Внедрение ПО"
            };

            var position1 = new Position
            {
                Id = 1,
                PositionName = "Программист"
            };
            var position2 = new Position
            {
                Id = 2,
                PositionName = "Менеджер"
            };

            var rating1 = new Rating
            {
                Mark = "Без оценки",
                Percent = 0
            };
            var rating2 = new Rating
            {
                Mark = "A",
                Percent = 80
            };
            var rating3 = new Rating
            {
                Mark = "B",
                Percent = 70
            };
            var rating4 = new Rating
            {
                Mark = "C",
                Percent = 60
            };

            var employee1 = new Employee
            {
                Id = 1,
                LastName = "Петренко",
                FirstName = "Владислав",
                MiddleName = "Александрович",
                PhoneNumber = "380634846176",
                AddressId = address1.Id,
                DepartmentId = department1.Id,
                PositionId = position1.Id,
                Salary = 10000,
                RatingMark = rating2.Mark,
            };
            var employee2 = new Employee
            {
                Id = 2,
                LastName = "Иванов",
                FirstName = "Дмитрий",
                MiddleName = "Валентинович",
                PhoneNumber = "380936548912",
                AddressId = address2.Id,
                DepartmentId = department2.Id,
                PositionId = position2.Id,
                Salary = 8000,
                RatingMark = rating4.Mark,
            };

            modelBuilder.Entity<Address>().HasData(address1, address2);
            modelBuilder.Entity<Department>().HasData(department1, department2);
            modelBuilder.Entity<Position>().HasData(position1, position2);
            modelBuilder.Entity<Rating>().HasData(rating1, rating2, rating3, rating4);
            modelBuilder.Entity<Employee>().HasData(employee1, employee2);
        }
    }
}

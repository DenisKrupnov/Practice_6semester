using System;
using System.Collections.Generic;

namespace SynergyPractice
{
    /// <summary>
    /// Класс WORKER, представляющий сотрудника организации
    /// </summary>
    public class Worker
    {
        // Приватные поля класса (инкапсуляция)
        private string _fullName;
        private string _position;
        private decimal _salary;
        private int _yearOfEmployment;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Worker()
        {
            _fullName = "Неизвестно";
            _position = "Неизвестно";
            _salary = 0;
            _yearOfEmployment = DateTime.Now.Year;
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="fullName">Фамилия и инициалы работника</param>
        /// <param name="position">Название занимаемой должности</param>
        /// <param name="salary">Зарплата</param>
        /// <param name="yearOfEmployment">Год поступления на работу</param>
        public Worker(string fullName, string position, decimal salary, int yearOfEmployment)
        {
            _fullName = fullName;
            _position = position;
            _salary = salary;
            _yearOfEmployment = yearOfEmployment;
        }

        /// <summary>
        /// Конструктор копирования
        /// </summary>
        /// <param name="other">Другой объект Worker</param>
        public Worker(Worker other)
        {
            if (other != null)
            {
                _fullName = other._fullName;
                _position = other._position;
                _salary = other._salary;
                _yearOfEmployment = other._yearOfEmployment;
            }
        }

        /// <summary>
        /// Деструктор
        /// </summary>
        ~Worker()
        {
            // Освобождение ресурсов (в данном случае не требуется)
        }

        // Свойства для доступа к полям (инкапсуляция)
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public decimal Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public int YearOfEmployment
        {
            get { return _yearOfEmployment; }
            set { _yearOfEmployment = value; }
        }

        /// <summary>
        /// Метод для изменения данных работника
        /// </summary>
        public void UpdateWorker(string fullName, string position, decimal salary, int yearOfEmployment)
        {
            _fullName = fullName;
            _position = position;
            _salary = salary;
            _yearOfEmployment = yearOfEmployment;
        }

        /// <summary>
        /// Метод для отображения полей класса
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"ФИО: {_fullName}");
            Console.WriteLine($"Должность: {_position}");
            Console.WriteLine($"Зарплата: {_salary:C}");
            Console.WriteLine($"Год поступления: {_yearOfEmployment}");
            Console.WriteLine($"Стаж: {GetWorkExperience()} лет");
            Console.WriteLine("-------------------------");
        }

        /// <summary>
        /// Метод для расчета стажа работы
        /// </summary>
        /// <returns>Стаж работы в годах</returns>
        public int GetWorkExperience()
        {
            return DateTime.Now.Year - _yearOfEmployment;
        }

        /// <summary>
        /// Метод для проверки превышения стажа
        /// </summary>
        /// <param name="minExperience">Минимальный стаж</param>
        /// <returns>True, если стаж превышает указанное значение</returns>
        public bool HasExperienceMoreThan(int minExperience)
        {
            return GetWorkExperience() > minExperience;
        }

        /// <summary>
        /// Переопределение метода ToString
        /// </summary>
        public override string ToString()
        {
            return $"{_fullName} | {_position} | {_salary:C} | {_yearOfEmployment} | Стаж: {GetWorkExperience()} лет";
        }
    }
}

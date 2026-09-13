using System;
using System.Collections.Generic;

namespace SynergyPractice
{
    public class Worker
    {
        private string _fullName;
        private string _position;
        private decimal _salary;
        private int _yearOfEmployment;

        public Worker()
        {
            _fullName = "Неизвестно";
            _position = "Неизвестно";
            _salary = 0;
            _yearOfEmployment = DateTime.Now.Year;
        }

        public Worker(string fullName, string position, decimal salary, int yearOfEmployment)
        {
            _fullName = fullName;
            _position = position;
            _salary = salary;
            _yearOfEmployment = yearOfEmployment;
        }

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
        ~Worker()
        {
        }

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

        public void UpdateWorker(string fullName, string position, decimal salary, int yearOfEmployment)
        {
            _fullName = fullName;
            _position = position;
            _salary = salary;
            _yearOfEmployment = yearOfEmployment;
        }
      
        public void DisplayInfo()
        {
            Console.WriteLine($"ФИО: {_fullName}");
            Console.WriteLine($"Должность: {_position}");
            Console.WriteLine($"Зарплата: {_salary:C}");
            Console.WriteLine($"Дата приема: {_yearOfEmployment}");
            Console.WriteLine($"Стаж: {GetWorkExperience()} лет");
            Console.WriteLine("-------------------------");
        }

        public int GetWorkExperience()
        {
            return DateTime.Now.Year - _yearOfEmployment;
        }

        public bool HasExperienceMoreThan(int minExperience)
        {
            return GetWorkExperience() > minExperience;
        }

        public override string ToString()
        {
            return $"{_fullName} | {_position} | {_salary:C} | {_yearOfEmployment} | Стаж: {GetWorkExperience()} лет";
        }
    }
}

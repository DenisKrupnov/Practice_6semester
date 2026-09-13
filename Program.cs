using System;
using System.Collections.Generic;

namespace SynergyPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Программа для работы с сотрудниками ===");
            Console.WriteLine("Университет «Синергия» - Практика 6 семестра");
            Console.WriteLine();

            List<Worker> workers = new List<Worker>();

            Console.Write("Введите количество сотрудников: ");
            int count;
            while (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
            {
                Console.Write("Ошибка! Введите положительное целое число: ");
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\n--- Ввод данных сотрудника №{i + 1} ---");

                Console.Write("Введите фамилию и инициалы: ");
                string fullName = Console.ReadLine();

                Console.Write("Введите название должности: ");
                string position = Console.ReadLine();

                Console.Write("Введите зарплату (в рублях): ");
                decimal salary;
                while (!decimal.TryParse(Console.ReadLine(), out salary) || salary < 0)
                {
                    Console.Write("Ошибка! Введите корректную сумму: ");
                }

                Console.Write("Введите дату приема на работу: ");
                int year;
                while (!int.TryParse(Console.ReadLine(), out year) || year < 1900 || year > DateTime.Now.Year)
                {
                    Console.Write($"Ошибка! Введите год от 1900 до {DateTime.Now.Year}: ");
                }

                Worker worker = new Worker(fullName, position, salary, year);
                workers.Add(worker);
            }

            Console.WriteLine("\n=== Список всех сотрудников ===");
            foreach (var w in workers)
            {
                w.DisplayInfo();
            }

            Console.Write("\nВведите минимальный стаж работы (в годах): ");
            int minExperience;
            while (!int.TryParse(Console.ReadLine(), out minExperience) || minExperience < 0)
            {
                Console.Write("Ошибка! Введите неотрицательное целое число: ");
            }
            Console.WriteLine($"\n=== Сотрудники со стажем более {minExperience} лет ===");
            bool found = false;
            foreach (var worker in workers)
            {
                if (worker.HasExperienceMoreThan(minExperience))
                {
                    Console.WriteLine($"- {worker.FullName} (стаж: {worker.GetWorkExperience()} лет, должность: {worker.Position})");
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Сотрудников с указанным стажем не найдено.");
            }
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}

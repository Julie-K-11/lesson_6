using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_6.Task_1
{
    public class Employee
    {
        public string FullName { get; set; }
        public string BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public string JobDescription { get; set; }
        public int Salary { get; set; }

        public void InputData()
        {
            Console.Write("Введіть ПІБ: ");
            FullName = Console.ReadLine();
            Console.Write("Введіть дату народження: ");
            BirthDate = Console.ReadLine();
            Console.Write("Введіть контактний телефон: ");
            PhoneNumber = Console.ReadLine();
            Console.Write("Введіть робочий email: ");
            Email = Console.ReadLine();
            Console.Write("Введіть посаду: ");
            Position = Console.ReadLine();
            Console.Write("Введіть опис службових обов'язків: ");
            JobDescription = Console.ReadLine();
            Console.Write("Введіть заробітну плату: ");
            Salary = int.Parse(Console.ReadLine());
        }

        public void DisplayData()
        {
            Console.WriteLine($"ПІБ: {FullName}");
            Console.WriteLine($"Дата народження: {BirthDate}");
            Console.WriteLine($"Контактний телефон: {PhoneNumber}");
            Console.WriteLine($"Робочий email: {Email}");
            Console.WriteLine($"Посада: {Position}");
            Console.WriteLine($"Опис службових обов'язків: {JobDescription}");
            Console.WriteLine($"Заробітна плата: {Salary}");
        }

        public void DisplaySalary()
        {
            Console.WriteLine($"Заробітна плата: {Salary}");
        }

        public static Employee operator +(Employee employee, int amount)
        {
            employee.Salary += amount;
            return employee;
        }

        public static Employee operator -(Employee employee, int amount)
        {
            employee.Salary -= amount;
            return employee;
        }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.Salary == employee2.Salary;
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.Salary != employee2.Salary;
        }

        public static bool operator <(Employee employee1, Employee employee2)
        {
            return employee1.Salary < employee2.Salary;
        }

        public static bool operator >(Employee employee1, Employee employee2)
        {
            return employee1.Salary > employee2.Salary;
        }

        public bool Equals(Employee anotherEmployee)
        {
            return this.Salary == anotherEmployee.Salary;
        }

        public override bool Equals(object obj)
        {
            if (obj is Employee other)
            {
                return this.Salary == other.Salary;
            }
            return false;
        }
    }
}

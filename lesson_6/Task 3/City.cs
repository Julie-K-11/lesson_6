using lesson_6.Task_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_6.Task_3
{
    public class City
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Population { get; set; }
        public string PhoneCode { get; set; }
        public string[] Districts { get; set; }

        public void InputData()
        {
            Console.Write("Введіть назву міста: ");
            Name = Console.ReadLine();
            Console.Write("Введіть назву країни: ");
            Country = Console.ReadLine();
            Console.Write("Введіть кількість жителів у місті: ");
            Population = int.Parse(Console.ReadLine());
            Console.Write("Введіть телефонний код міста: ");
            PhoneCode = Console.ReadLine();

            Console.Write("Введіть кількість районів міста: ");
            int districtCount = int.Parse(Console.ReadLine()); 
            Districts = new string[districtCount];
            for (int i = 0; i < districtCount; i++)
            {
                Console.Write($"Введіть назву району {i + 1}: ");
                Districts[i] = Console.ReadLine();
            }

        }

        public void DisplayData()
        {
            Console.WriteLine($"Назва міста: {Name}");
            Console.WriteLine($"Назва країни: {Country}");
            Console.WriteLine($"Кількість жителів: {Population}");
            Console.WriteLine($"Телефонний код: {PhoneCode}");

            Console.WriteLine("Райони міста:");
            foreach (var district in Districts)
            {
                Console.WriteLine($"- {district}");
            }
        }

        public void DisplayPopulation()
        {
            Console.WriteLine($"Кількість жителів: {Population}");
        }
        public static City operator +(City city, int amount)
        {
            city.Population += amount;
            return city;
        }

        public static City operator -(City city, int amount)
        {
            city.Population -= amount;
            return city;
        }

        public static bool operator ==(City city1, City city2)
        {
            return city1.Population == city2.Population;
        }

        public static bool operator !=(City city1, City city2)
        {
            return city1.Population != city2.Population;
        }

        public static bool operator <(City city1, City city2)
        {
            return city1.Population < city2.Population;
        }

        public static bool operator >(City city1, City city2)
        {
            return city1.Population > city2.Population;
        }

        public override bool Equals(object obj)
        {
            if (obj is City other)
            {
                return this.Population == other.Population;
            }
            return false;
        }
    }
}

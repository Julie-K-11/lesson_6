using lesson_6.Task_1;
using lesson_6.Task_2;
using lesson_6.Task_3;
using lesson_6.Task_4;

namespace lesson_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("______________________________________1______________________________________");
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            Console.WriteLine("\nВведіть данні для співробітника 1:");
            employee1.InputData();

            Console.WriteLine("\nВведіть данні для співробітника 2:");
            employee2.InputData();

            Console.WriteLine("\nСпівробіник 1 - данні:");
            employee1.DisplayData();

            Console.WriteLine("\nСпівробіник 2 - данні:");
            employee2.DisplayData();

            employee1 = employee1 + 1000;
            employee2 = employee2 - 500;

            Console.WriteLine("\nПісля підвищення запрлати Співробіника 1 на 1000:");
            employee1.DisplaySalary();

            Console.WriteLine("Після зниження запрлати Співробіника 2 на 500:");
            employee2.DisplaySalary();

            Console.WriteLine($"Чи мають співробітник 1 та 2 однакову зарплату? {employee1 == employee2}");
            Console.WriteLine($"Зарплата Спіробіника 1 вища за запралату Співробіника 2? {employee1 > employee2}");
            Console.WriteLine($"Зарплата Спіробіника 1 нижча за запралату Співробіника 2? {employee1 < employee2}");


            Console.WriteLine("\n______________________________________2______________________________________");
            int rows1, cols1, rows2, cols2;

            EnterSize(out rows1, out cols1, "матриці 1");
            Matrix matrix1 = new Matrix(rows1, cols1);
            Console.WriteLine("\nВведіть данні для матриці 1:");
            matrix1.InputData();
            Console.WriteLine();

            EnterSize(out rows2, out cols2, "матриці 2");
            Matrix matrix2 = new Matrix(rows2, cols2);
            Console.WriteLine("\nВведіть данні для матриці 2:");
            matrix2.InputData();

            Console.WriteLine("\nМатриця 1:");
            matrix1.DisplayData();

            Console.WriteLine("\nМатриця 2:");
            matrix2.DisplayData();

            Console.WriteLine($"\nСума матриць = \n{matrix1 + matrix2}");
            Console.WriteLine($"Різниця матриць = \n{matrix1 - matrix2}");
            Console.WriteLine($"Добуток матриць = \n{matrix1 * matrix2}");
            Console.WriteLine($"Матриця 1 * 2 =  \n{matrix1 * 2}");
            Console.WriteLine($"Чи Матриця 1 = Mатриці 2 ? {matrix1 == matrix2}");

            Console.WriteLine("\n______________________________________3______________________________________");
            City city1 = new City();
            City city2 = new City();

            Console.WriteLine("\nВедіть данні Міста 1:");
            city1.InputData();

            Console.WriteLine("\nВедіть данні Міста 2:");
            city2.InputData();

            Console.WriteLine("\nМісто 1:");
            city1.DisplayData();

            Console.WriteLine("\nМісто 2:");
            city2.DisplayData();

            city1 = city1 - 500;
            city2 = city2 + 5000;

            Console.WriteLine("\nКількість жителей Міста 1 зменшилася на 500:");
            city1.DisplayPopulation();

            Console.WriteLine("Кількість жителей Міста 2 збільшилася на 5000:");
            city2.DisplayPopulation();

            Console.WriteLine($"Місто 1 та Місто 2 мають однакову кількість жителей? {city1 == city2}");
            Console.WriteLine($"Кількість жителей Міста 1 більша за кількість жителей Міста 2? {city1 > city2}");
            Console.WriteLine($"Кількість жителей Міста 1 менша за кількість жителей Міста 2 ? {city1 < city2}");

            Console.WriteLine("\n______________________________________4______________________________________");
            CreditCard card1 = new CreditCard();
            CreditCard card2 = new CreditCard();

            Console.WriteLine("\nВведіть данні Кредитної Картики 1:");
            card1.InputData();

            Console.WriteLine("\nВведіть данні Кредитної Картики 2:");
            card2.InputData();

            Console.WriteLine("\nКрединта Картка 1:");
            card1.DisplayData();

            Console.WriteLine("\nКрединта Картка 2:");
            card2.DisplayData();

            card1 = card1 + 2000;
            card2 = card2 - 10;

            Console.WriteLine("\nКредитна Картка 1 після поповнення балансу на 2000:");
            card1.DisplayBalance();

            Console.WriteLine("Кредитна Картка 2 після зняття 10 грн з балансу:");
            card2.DisplayBalance();

            Console.WriteLine($"Чи мають однаковий CVC Крединта Картка 1 та Кредитна Картка 2? {card1 == card2}");
            Console.WriteLine($"Баланс на Кредитній Картці 1 більший за баланс на Крединтій Карці 2? {card1 > card2}");
            Console.WriteLine($"Баланс на Кредитній Картці 1 менший за баланс на Крединтій Карці 2? {card1 < card2}");

        }

        public static int ReadInt()
        {
            int result;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    return result;
                }
                Console.Write("Некоректний ввід. Спробуйте ще раз: ");
            }
        }

        public static void EnterSize(out int rows, out int cols, string matrixName)
        {
            Console.Write($"Введіть кількість рядків {matrixName}: ");
            rows = ReadInt();
            Console.Write($"Введіть кількість стовпців {matrixName}: ");
            cols = ReadInt();
        }
    }
}
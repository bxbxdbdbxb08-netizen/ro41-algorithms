using System;

namespace Gcd
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите целое число a (a >= 0): ");
            string inputA = Console.ReadLine();

            Console.Write("Введите целое число b (b >= 0): ");
            string inputB = Console.ReadLine();

            if (!int.TryParse(inputA, out int a) || !int.TryParse(inputB, out int b) || a < 0 || b < 0)
            {
                Console.WriteLine("Ошибка: введите целые числа >= 0.");
                return;
            }

            if (a == 0 && b == 0)
            {
                Console.WriteLine("Ошибка: числа не могут быть одновременно равны 0.");
                return;
            }

            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }

            Console.WriteLine($"Результат (НОД): {a}");
        }
    }
}

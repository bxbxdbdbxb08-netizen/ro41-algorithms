using System;

namespace SecondsConverter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Введите целое число секунд (>= 0): ");
            string? input = Console.ReadLine();

            if (!long.TryParse(input, out long totalSeconds))
            {
                Console.WriteLine("Ошибка: введите корректное целое число.");
                return;
            }

            if (totalSeconds < 0)
            {
                Console.WriteLine("Ошибка: число секунд не может быть отрицательным.");
                return;
            }

            long hours = totalSeconds / 3600;
            long rem = totalSeconds % 3600;
            long minutes = rem / 60;
            long seconds = rem % 60;

            Console.WriteLine($"Результат: {hours} ч {minutes} мин {seconds} сек ({hours:D2}:{minutes:D2}:{seconds:D2})");
        }
    }
}

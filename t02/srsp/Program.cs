using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число n (не меньше 0): ");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int n) || n < 0)
        {
            Console.WriteLine("Ошибка: некорректный ввод. Введите целое число >= 0.");
            return;
        }

        int sum = 0;
        int count = 0;

        do
        {
            sum += n % 10;
            count++;
            n /= 10;
        } while (n > 0);

        Console.WriteLine($"Количество цифр: {count}");
        Console.WriteLine($"Сумма цифр: {sum}");
    }
}
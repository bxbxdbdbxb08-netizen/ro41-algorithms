using System;


int count = 0;
int sum = 0;
int fives = 0;

int g = Grades.Read();

while (g != Grades.Stop)
{
    if (Grades.IsValid(g))
    {
        count++;
        sum += g;

        if (g == Grades.Max)
        {
            fives++;
        }
    }
    else
    {
        Console.WriteLine($"Некорректная оценка (введите от {Grades.Min} до {Grades.Max} или {Grades.Stop} для завершения)");
    }

    g = Grades.Read();
}

Grades.PrintStats(count, sum, fives);


static class Grades
{
    public const int Min = 2;
    public const int Max = 5;
    public const int Stop = 0;

    
    public static int Read()
    {
        Console.Write("Введите оценку (0 — конец): ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int grade))
        {
            return grade;
        }

        return -1;
    }

    
    public static bool IsValid(int g)
    {
        return g >= Min && g <= Max;
    }

  
    public static void PrintStats(int count, int sum, int fives)
    {
        if (count == 0)
        {
            Console.WriteLine("Оценок нет");
        }
        else
        {
            double average = (double)sum / count;
            Console.WriteLine($"Количество оценок: {count}");
            Console.WriteLine($"Средний балл: {average:F2}");
            Console.WriteLine($"Количество пятёрок: {fives}");
        }
    }
}

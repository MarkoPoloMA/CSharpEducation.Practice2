using System;

namespace Practice_2
{
    class ProgramThird
    {
        static void Main()
        {
            Console.Write("Введите значение a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите значение b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Введите значение f: ");
            double f = double.Parse(Console.ReadLine());

            if (a == 0)
                return;

            double result = (a + b - f / a) + f * a * a - (a + b);

            Console.WriteLine($"Результат выражения: {result}");

            Console.ReadKey();
        }
    }
}

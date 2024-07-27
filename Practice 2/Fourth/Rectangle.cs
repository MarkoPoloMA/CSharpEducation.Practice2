using System;

namespace Practice_2
{
    class ProgramThird
    {
        static void Main()
        {
            Console.WriteLine("Введите высоту треугольника: ");
            int heigth = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите элемент чем заполнять: ");
            char elem = char.Parse(Console.ReadLine());

            for (var i = 1; i <= heigth; i++)
            {
                string output = "";
                for (var j = 0; j < i; j++)
                {
                    output += elem.ToString();
                }
                Console.WriteLine(output);
            }

            Console.ReadKey();
        }
    }
}
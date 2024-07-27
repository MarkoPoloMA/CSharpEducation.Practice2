using System;

namespace Practice_2
{
    class RecB
    {
        public void RectangleB()
        {
            Console.WriteLine("Введите высоту треугольника: ");
            int heigth = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите элемент чем заполнять: ");
            char elem = char.Parse(Console.ReadLine());

            for (var i = 1; i <= heigth; i++)
            {
                string output = "";
                int spaces = heigth - i;
                int symbols = i;

                for (var j = 0; j < spaces; j++)
                    output += " ";
                for (var j = 0; j < symbols; j++)
                    output += "*";

                Console.WriteLine(output);
            }
        }
    }
}

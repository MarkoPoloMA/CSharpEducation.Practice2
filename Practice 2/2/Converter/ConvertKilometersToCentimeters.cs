using System;

namespace Practice_2
{
    internal class ConvertKilometersToCentimeters
    {
        public void ConvertKmToCm()
        {
            Console.Write("Введите число в километрах: ");

            double kilometers = double.Parse(Console.ReadLine());
            double centimeters = kilometers * 100000;

            Console.WriteLine($"{kilometers} километров = {centimeters} сантиметров");
        }
    }
}
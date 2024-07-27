using System;

namespace Practice_2
{
    internal class ConvertMetersToKilometers
    {
        public void ConvertMetToKm()
        {
            Console.Write("Введите количество метров: ");

            double meters = double.Parse(Console.ReadLine());
            double kilometers = meters / 1000;

            Console.WriteLine($"{meters} метров = {kilometers} километров");
        }
    }
}
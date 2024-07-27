using System;

namespace Practice_2
{
    internal class ConvertMetersPerSecondToKilometersPerHour
    {
        public void ConvertMsToKh()
        {
            Console.Write("Введите скорость: ");

            double metersPerSecond = double.Parse(Console.ReadLine());
            double kilometersPerHour = metersPerSecond * 3.6;

            Console.WriteLine($"{metersPerSecond} м/с = {kilometersPerHour} км/ч");
        }
    }
}
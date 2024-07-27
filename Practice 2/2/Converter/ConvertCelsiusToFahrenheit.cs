using System;

namespace Practice_2
{
    internal class ConvertCelsiusToFahrenheit
    {
        public void ConCelToFar()
        {
            Console.Write("Введите температуру в градусах C: ");

            double cel = double.Parse(Console.ReadLine());
            double far = cel * 9 / 5 + 32;

            Console.WriteLine($"{cel} градусов по Цельсию = {far} градусов по Фаренгейту");
        }
    }
}
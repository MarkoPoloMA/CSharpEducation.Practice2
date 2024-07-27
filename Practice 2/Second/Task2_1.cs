using System;

namespace Practice_2
{
    internal class Task2_1
    {
        public void Navigator()
        {
            Console.WriteLine("Выберите что хотите сделать:");
            Console.WriteLine("1 - Преобразовать метры в километры");
            Console.WriteLine("2 - Преобразовать километры в сантиметры");
            Console.WriteLine("3 - Преобразовать м/с в км/ч");
            Console.WriteLine("4 - Преобразовать градусы C в градусы F");
            Console.WriteLine("5 - Выйти из меню");
        }
        public void Converter()
        {

            while (true)
            {
                Console.ReadKey();
                Console.Clear();
                Navigator();
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        var Converter1 = new ConvertCelsiusToFahrenheit();
                        Converter1.ConCelToFar();
                        break;
                    case 2:
                        var Converter2 = new ConvertKilometersToCentimeters();
                        Converter2.ConvertKmToCm();
                        break;
                    case 3:
                        var Converter3 = new ConvertMetersPerSecondToKilometersPerHour();
                        Converter3.ConvertMsToKh();
                        break;
                    case 4:
                        var Converter4 = new ConvertMetersToKilometers();
                        Converter4.ConvertMetToKm();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Повторите снова");
                        break;
                }
            }

        }
    }
}
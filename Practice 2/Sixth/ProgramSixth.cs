/*using System;

namespace Practice_2
{
    class ProgramSixth
    {
        static void Main()
        {
            const string text = "Hello World";
            char elem = 'e';
            Calculate(text, elem);

            Console.Write("Введите строку: ");
            string userInputText = Console.ReadLine();
            Console.Write("Введите символ: ");
            char userInputChar = Console.ReadLine()[0];

            Calculate(userInputText, userInputChar);

            Console.ReadKey();
        }
        static void Calculate(string text, char elem)
        {
            int count = 0;
            foreach(char x in text)
                if (elem == x)
                    count++;

            double percentage = (double)count / text.Length * 100;

            Console.WriteLine($"Процент вхождения символа '{elem}' в строку '{text}' = {percentage} %");
        }
    }
}
*/
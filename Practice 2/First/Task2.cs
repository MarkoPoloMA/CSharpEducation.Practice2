using System;

namespace Practice_2
{
    internal class Task2
    {
        int i = 0;
        string output;
        public void InitElementsWithWhileCycle(int value)
        {
            while (value-- != 0)
            {
                i++;
                output += i.ToString() + " ";
            }
            Console.WriteLine(output);
        }
    }
}
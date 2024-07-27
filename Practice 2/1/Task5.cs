using System;

namespace Practice_2
{
    internal class Task5
    {
        int i = 0;
        string output;
        public void InitWordWithWhileCycle(int value)
        {
            while (--value != 0)
            {
                i++;
                output += Console.ReadLine() + " ";
            }
            Console.WriteLine(output);
        }
    }
}
using System;

namespace Practice_2
{
    internal class Task4
    {
        string output;
        public void InitWordWithForCycle(int value)
        {
            for (var i = 0; i <= value; i++)
                output += Console.ReadLine() + " ";
            Console.WriteLine(output);
        }
    }
}
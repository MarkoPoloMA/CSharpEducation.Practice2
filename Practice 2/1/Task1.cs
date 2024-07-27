using System;

namespace Practice_2
{
    internal class Task1
    {
        string output;
        public void InitElementsWithForCycle(int value)
        {
            for (var i = 1; i <= value; i++)
                output += i.ToString() + " ";
            Console.WriteLine(output);
        }
    }
}
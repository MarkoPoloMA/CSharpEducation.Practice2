using System;

namespace Practice_2
{
    internal class Task3
    {
        int i = 0;
        string output;
        public void InitElementsWithDoWhileCycle(int value)
        {
            do
            {
                i++;
                output += i.ToString() + " ";
            } while (--value != 0);

            Console.WriteLine(output);
        }
    }
}
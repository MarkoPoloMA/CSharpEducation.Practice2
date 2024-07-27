using System;

namespace Practice_2
{
    class Program
    {
        static void Main()
        {
            var test1 = new Task1();
            test1.InitElementsWithForCycle(3);

            var test2 = new Task2();
            test2.InitElementsWithWhileCycle(3);

            var test3 = new Task3();
            test3.InitElementsWithDoWhileCycle(3);

            var test4 = new Task4();
            test4.InitWordWithForCycle(3);

            var test5 = new Task5();
            test5.InitWordWithWhileCycle(3);

            var test6 = new Task6();
            test6.InitWordWithDoWhileCycle(3);
        }
    }
}

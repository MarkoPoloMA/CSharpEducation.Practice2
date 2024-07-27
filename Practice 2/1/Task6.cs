namespace Practice_2
{
    internal class Task6
    {
        int i = 0;
        string output;
        public void InitWordWithDoWhileCycle(int value)
        {
            do
            {
                i++;
                output += i.ToString() + " ";
            } while (--value != 0);
        }
    }
}
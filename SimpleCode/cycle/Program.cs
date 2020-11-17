using System;

namespace cycle
{
    /*
     * Цикл while
     */
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            do
            {
                count++;
                Console.WriteLine(count);
            } while (count < 5);
        }
    }
}

using System;

namespace L28
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 2, 10, 5, 6, 77, 89, 1 };
            int[] myArray2 = myArray[0..4];
            Console.WriteLine(myArray[^1]);
        }
    }
}

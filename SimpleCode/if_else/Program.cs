using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = int.Parse(Console.ReadLine());

            if (a == 5)
            {
                Console.WriteLine("а равно 5");
            }
            else
            {
                Console.WriteLine("а не равно 5");    
            }
        }
    }
}

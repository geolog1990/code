using System;

namespace Tswitch
{
    class Program
{
    static void Main(string[] args)
    {
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("ввели число 1");
                    break;
                case 2:
                    Console.WriteLine("ввели число 2");
                    break;
                default:
                    Console.WriteLine("ввели не то");
                    break;
            }
        }
}
}

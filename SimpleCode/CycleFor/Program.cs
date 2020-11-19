using System;

namespace CycleFor
{
    /*
     * Цикл for 
     */
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Введдите высоту прямоугольника");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину прямоугольника");
            int width = int.Parse(Console.ReadLine());
            */
            for (int i = 0; i <= 10; i++)
            {
                
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("#");
                }
                
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("ghbdtn");

            for (int i = 10; i <= 10; i--)
            {

                for (int j = 10; j < i; j--)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
        }
    }
}

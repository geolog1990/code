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

            Console.WriteLine("Введдите высоту треугольника");
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
           
            for (int i = 0; i < height; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }
            }
        }

        
    }
}

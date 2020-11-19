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
            Console.WriteLine("Введдите высоту прямоугольника");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину прямоугольника");
            int width = int.Parse(Console.ReadLine());
            for (int i = 1; i <= height; i++)
            {
                
                for (int j = 0; j <= width; j++)
                {
                    Console.Write("#");
                }
                
                Console.WriteLine();
            }
        }
    }
}

using System;

namespace L35
{
    class Program
    {
        static int Sum(int a, int b) 
        {
            int result = a + b;
            return result;
        }

        static void PrintResult(int result) 
        {
            Console.WriteLine("Результат сложения: " + result);
        }

        static void PrintManyTimes(int a, string sim) 
        {
            for (int i = 0; i <= a; i++)
            {
                Console.Write(sim);
            }
        }

        static void Main(string[] args)
        {
            int a;
            string s;
            Console.WriteLine("Введите символ");
            s = Console.ReadLine();
            Console.WriteLine("Введите количество");
            a = int.Parse(Console.ReadLine());

            PrintManyTimes(a, s);

            /*
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            c = Sum(a, b);                       
                
            PrintResult(c);
            */


        }
    }
}

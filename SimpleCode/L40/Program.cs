using System;

namespace L40
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            /*if (str == null)
            {
                Console.WriteLine("нет данных");
            }
            else
            {
                Console.WriteLine(str);
            }*/
            Console.WriteLine(str ?? "нет данных");

        }
    }
}
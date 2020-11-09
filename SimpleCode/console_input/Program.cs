using System;

//ввод данных в консоль

namespace console_input
{
    class Program
    {
        static void Main(string[] args)
        {
            string data;

            data = Console.ReadLine();
            Console.WriteLine("Привет, " + data + "!!!");
        }
    }
}

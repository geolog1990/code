using System;

namespace if_else
{
    class Program
    {
       /* public static bool GetTemperature()
        {
            return true;
        }

        public static bool GetCoolingStatus()
        {
            return true;
        }
       */
        static void Main(string[] args)
        {
            /*int fanSpeed = 0;
            bool isHighTemperature = false;
            bool hasNoCooling = fanSpeed <= 0;
            
            if (GetTemperature() || GetCoolingStatus())
            {
                Console.WriteLine("Угроза повреждения процессора!");
            }
       */
            int a;

            a = int.Parse(Console.ReadLine());
            if (a % 2 == 1)
            {
                Console.WriteLine("Нечетная");
            }
            else
            {
                Console.WriteLine("четная");
            }
            
        }
    }
}

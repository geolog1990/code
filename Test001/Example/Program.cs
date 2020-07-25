using System;

namespace Example
{
    internal class Program
    {
        public static void Main(string[] args)
        {



            HorLine l1 = new HorLine(5,20,5, '#');
            l1.Draw();
            VertLine l2 = new VertLine(3,10 ,7 , '+');
            l2.Draw();
           
            

            
            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Point
    {
        int z = 3;
        public int x = 55;
        private int y = 44;
        public Color color;

        private void PrintX()
        {
            Console.WriteLine($"X: {x}");
        }

        public void PrintY()
        {
            Console.WriteLine($"Y: {y}");
        }

        public void PrintPoint()
        {
            PrintX();
            PrintY();
        }
    }
}

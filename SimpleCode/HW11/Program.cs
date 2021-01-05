using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11
{
    class Program
    {
        static int IndexOff(int []array,  int value) 
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
                
            }

            return -1;
        }

        static void Main(string[] args)
        {
            int[] myArray = { -2, 23, 5, -10 };
            int result = IndexOff(myArray, 23);
            Console.WriteLine(result);

        }
    }
}

using System;

namespace HW10
{
    class Program
    {
        static int Indeks(int [] array, int value) 
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
            int q, value;
            int[] myArray = {5, 9, 10, 45, 2, 100};
            Console.WriteLine("ВВедите искомую величину");
            value = int.Parse(Console.ReadLine());
            q = Indeks(myArray, value);
            Console.WriteLine(q);
        }
    }
}     

using System;

namespace L30
{
    class Program
    {
        static void Main(string[] args)
        {   //вывод массива

            /*
            int [,] myArray;
            myArray = new int[,]
            {
                {2,45,12,51,51 },
                {6,7,8,3,1 },
                {6,7,8,3,1 },
                {1,5,65,78,13 }
            };

            for (int x = 0; x < myArray.GetLength(0); x++)
            {
                for (int y = 0; y < myArray.GetLength(1); y++)
                {
                    Console.Write(myArray[x,y] + "\t");
                }
                Console.WriteLine();
            }
               */
            string[,] myArray;
            myArray = new string[2, 3];
            
            for (int x = 0; x < myArray.GetLength(0); x++)
            {
                for (int y = 0; y < myArray.GetLength(1); y++)
                {
                    myArray[x, y] = Console.ReadLine();
                }
            }

            for (int x = 0; x < myArray.GetLength(0); x++)
            {
                for (int y = 0; y < myArray.GetLength(1); y++)
                {
                    Console.Write(myArray[x, y] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

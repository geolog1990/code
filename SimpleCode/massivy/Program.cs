using System;
using System.Linq;

namespace massivy
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] myArray = new int[5] {5,6,7,8,9};
            myArray[0] = 3;
            int[] myArray = Enumerable.Repeat(5, 10).ToArray();
            int a = myArray[0];
            Console.WriteLine(myArray.Length);
            */
            int[] myArray = new int [4];
            //заполнение массива
            Console.WriteLine("введите 4 элемента массива");
            for (int i = 0; i < 4; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }
            //вывод массива в обратном порядке
            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }
            //сумма четных чисел
            int sumCV = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                
                if (myArray[i] % 2 == 0) 
                {
                    sumCV = sumCV + myArray[i];
                }
            }
            //наименьшее число
            int minNumber = myArray[0];
            for (int i = 0; i < myArray.Length; i++)
            {
                minNumber = minNumber < myArray[i] ? minNumber : myArray[i];
            }

            Console.WriteLine("наименьшее число в массиве = " + minNumber);

            Console.WriteLine("сумма четных чисел = " + sumCV);
         }
    }
}

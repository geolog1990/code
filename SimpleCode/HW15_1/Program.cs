using System;

namespace HW15_1 

    // Вывод массива на консоль с помощью рекурсии
    // Вывод суммы элементов массива с помощью рекурсии
    // Вывод суммы цифр числа
{
    class Program
    {
        static void PrintArray(int[] MyArray, int i = 0) // Вывод массива
        {
            
            if (i < MyArray.Length)
            {
                Console.WriteLine(MyArray[i]);
                PrintArray(MyArray, i + 1);
            }
        }

        static int SumArray(int[] MyArray, int i = 0) // Сумма элементов массива
        {            
            if (i >= MyArray.Length)
                return 0;
            int result = SumArray(MyArray, i + 1);
            return MyArray[i] + result; 
                
        }

        static int SumNumbersOfArray(int value) 
        {
            if (value / 10 == 0)
                return value;
            int sum = (value % 10) + SumNumbersOfArray(value / 10);
            return sum;

        }
        
        static void Main(string[] args)
        {
            //int[] array = { 1, 2, 3, 4, 5 };
            //printarray(array);
            //int result = sumarray(array);
            
            int myValue = 560; 
            int sum = SumNumbersOfArray(myValue);
            Console.WriteLine(sum);
        }
    }
}

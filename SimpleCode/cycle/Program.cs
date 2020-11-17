using System;

namespace cycle
{
    /*
     * Цикл while
     */
    class Program
    {
        static void Main(string[] args)
        {
            uint oddNumbersCount = 0; //нечетные числа
            uint evenNumbersCount = 0; //четные числа
            int oddNumbersSum = 0;
            int evenNumbersSum = 0;
            Console.WriteLine("Введите начало диапазона");
            int currentValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец диапазона");
            int limit = int.Parse(Console.ReadLine());

            while (currentValue <= limit)
            {
                if (currentValue % 2 == 0)
                {
                    evenNumbersSum += currentValue;
                    evenNumbersCount++;
                }
                else 
                {
                    oddNumbersSum = oddNumbersSum + currentValue;
                    oddNumbersCount++;
                }
                currentValue++;
            }
            
            Console.WriteLine("Количество нечётных чисел: " + oddNumbersCount);
            Console.WriteLine("Количество чётных чисел: " + evenNumbersCount);
            Console.WriteLine("Сумма нечётных чисел: " + oddNumbersSum);
            Console.WriteLine("Сумма чётных чисел: " + evenNumbersSum);

            Console.ReadLine();
        }

    }
}

using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую цифру");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую цифру");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Какую операцию мне произвести?");
            string str = Console.ReadLine();
            /*
            switch (str)
            {
                case "+":
                    Console.WriteLine(firstNumber + "+" + secondNumber + "=" + (firstNumber + secondNumber));
                    break;
                case "-":
                    Console.WriteLine(firstNumber + "-" + secondNumber + "=" + (firstNumber - secondNumber));
                    break;
                case "*":
                    Console.WriteLine(firstNumber + "*" + secondNumber + "=" + (firstNumber * secondNumber));
                    break;
                case "/":
                    Console.WriteLine(firstNumber + "/" + secondNumber + "=" + (firstNumber / secondNumber));
                    break;
                default:
                    Console.WriteLine("Этого я пока не умею");
                    break;
            }
            */
            if (str == "+")
            {
                Console.WriteLine(firstNumber + str + secondNumber + "=" + (firstNumber + secondNumber));
            }
            else 
            {
                if (str == "-")
                {
                    Console.WriteLine(firstNumber + str + secondNumber + "=" + (firstNumber - secondNumber));
                }
                else
                {
                    if (str == "*") 
                    {
                        Console.WriteLine(firstNumber + str + secondNumber + "=" + (firstNumber * secondNumber));
                    }
                    else
                    {
                        Console.WriteLine(firstNumber + str + secondNumber + "=" + (firstNumber / secondNumber));
                    }
                }
            }
        }
    }
}

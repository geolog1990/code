using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую цифру");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую цифру");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Какую операцию мне произвести? : '+' '-' '*' '/'");
            string action = Console.ReadLine();
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
            if (action == "+")
            {
                Console.WriteLine(firstNumber + action + secondNumber + "=" + (firstNumber + secondNumber));
            }
            else if (action == "-")
            {
                Console.WriteLine(firstNumber + action + secondNumber + "=" + (firstNumber - secondNumber));
            }
            else if (action == "*")
            {
                Console.WriteLine(firstNumber + action + secondNumber + "=" + (firstNumber * secondNumber));
            }
            else if (action == "/")
            {
                if (secondNumber == 0)
                    Console.WriteLine(0);
                else
                    Console.WriteLine(firstNumber + action + secondNumber + "=" + (firstNumber / secondNumber));
            }
            else 
            {
                Console.WriteLine("Этого я пока не умею делать!");
            }

            Console.ReadLine();
        }
    }
}

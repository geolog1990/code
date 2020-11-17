using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double firstNumber, secondNumber;
                string action;
                try
                {
                    Console.WriteLine("Введите первую цифру");
                    firstNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите вторую цифру");
                    secondNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine("Какую операцию мне произвести? : '+' '-' '*' '/'");
                }
                catch (Exception)
                {
                    Console.WriteLine("Не удалось преобразовать строку в число");
                    Console.ReadLine();
                    continue;
                }
                                
                action = Console.ReadLine();

                switch (action)
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
                        if (secondNumber == 0)
                            Console.WriteLine(0);
                        else
                            Console.WriteLine(firstNumber + "/" + secondNumber + "=" + (firstNumber / secondNumber));
                        break;
                    default:
                        Console.WriteLine("Этого я пока не умею");
                        break;
                }

                /*
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
                */
                Console.ReadLine();
            }
            
        }
    }
}

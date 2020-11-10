using System;
using System.Globalization;

// конвертация строки
// parse и tryparse

namespace Try_Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "5";

            int a;

            bool result = int.TryParse(str, out a);

            if (result)
            {
                Console.WriteLine("Конвертация успешна" + result + a);
            }
            else
            {
                Console.WriteLine("Не удалось" + result);
            }
            /*try
            {
                double a = double.Parse(str);
                Console.WriteLine("Успешная конвертация, а = " + a);
            }
            catch (Exception)
            {

                Console.WriteLine("Ошибка при конвертации");
            }
            /*


            /*
             * NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            { 
                NumberDecimalSeparator = ".",
            };
            
            double a = double.Parse(str, numberFormatInfo);
            */
        }
    }
}

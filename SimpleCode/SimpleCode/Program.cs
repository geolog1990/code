using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "12";

            int a;
            
            bool result = int.TryParse(s, out a);

            if (result)
            {
                Console.WriteLine("Операция успешна, значение = " + a);
            }
            else
            {
                Console.WriteLine("Не удалось конвертировать!");
            }
            Console.WriteLine(result);
        }
    }
}

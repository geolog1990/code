using System;

namespace Ternar
{
    class Program
    {
        static void Main(string[] args)
        {
            bool accessAllowed;
            string storedPassword = "qwerty";
            string enteredPassword = Console.ReadLine();
            /*if (enteredPassword == storedPassword)
            {
                accessAllowed = true;
            }
            else
            {
                accessAllowed = false;
            }*/
            accessAllowed = enteredPassword == storedPassword ? true : false;
            Console.WriteLine(accessAllowed);

        }   
    }
}

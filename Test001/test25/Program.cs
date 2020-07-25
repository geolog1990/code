using System.IO;

namespace test25
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a, b;
            char result;
            StreamReader streamReader = new StreamReader("input.txt");
            string s = streamReader.ReadToEnd();

            // if (a < b)
            // {
            //     result = "<";
            // }
            // else if (a > b)
            // {
            //     result = ">";
            // }
            // else
            // {
            //     result = "=";
            // }
        }
    }
}
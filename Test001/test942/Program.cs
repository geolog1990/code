using System.IO;

namespace test942
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader("input.txt");
            string N = streamReader.ReadLine();
        }
    }
}
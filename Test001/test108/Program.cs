using System.IO;

namespace test108
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader("input.txt");
            string s = streamReader.ReadLine();
            using (StreamWriter streamWriter = new StreamWriter("output.txt"))
            {
                streamWriter.Write(s);
            }
        }
    }
}
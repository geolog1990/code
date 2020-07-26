using System;
using System.IO;
using System.Linq;

namespace test25
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a, b;
            char result;
            StreamReader streamReader = new StreamReader("input.txt");
            var s = streamReader.ReadToEnd().Split(new Char []{' ', '\r', '\n'});
            try
            {
                a = Int32.Parse(s.First());
                b = Int32.Parse(s.Last());
                
                if (a < b)
                {
                    result = '<';
                }
                else if (a > b)
                {
                    result = '>';
                }
                else
                {
                    result = '=';
                }

                using (StreamWriter streamWriter = new StreamWriter("output.txt"))    
                {
                    streamWriter.Write(result);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
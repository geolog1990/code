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
            string s = streamReader.ReadToEnd();
            try
            {
                a = s.First();
                b = s.Last();
                
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
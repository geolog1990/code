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
            var s = streamReader.ReadToEnd().Split(new char[]{ ' ','\n','\r'});
            
            try
            {
                a = Convert.ToInt32(s.First()) ;
                b = Convert.ToInt32(s.Last());
                
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
using System;
using System.CodeDom.Compiler;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Test001
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           
            StreamReader streamReader = new StreamReader("input.txt");
            string s = streamReader.ReadToEnd();
            try
            {
                string[] temp = s.Split(' ');
                int sum = 0;
                foreach (string el in temp)
                {
                    sum += Int32.Parse(el);
                }
                using (StreamWriter streamWriter = new StreamWriter("output.txt"))
                {
                    streamWriter.WriteLine(sum);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
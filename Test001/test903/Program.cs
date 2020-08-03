using System;
using System.IO;

namespace test903
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader("input.txt");
            string s = streamReader.ReadLine();
            int a = Int32.Parse(s);
            a = a + 1;
            using (StreamWriter streamWriter = new StreamWriter("output.txt"))
            {  
               streamWriter.Write(a); 
            }
        }
    }
}
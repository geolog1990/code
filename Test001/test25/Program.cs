using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace test25
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            char result;
            using (StreamReader streamReader = new StreamReader("input.txt"))
            {
                while (!streamReader.EndOfStream)

                {
                    list.Add(int.Parse(streamReader.ReadLine()));
                }
            }

            if (list[0] > list[1])
                result = '>';
            else if (list[0] < list[1])
                result = '<';
            else
            {
                result = '=';
            }

            using (StreamWriter streamWriter = new StreamWriter("output.txt"))
            {
                streamWriter.Write(result);
            }

        }
    }
}
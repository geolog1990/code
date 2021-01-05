using System;

namespace HW12
{
    class Program
    {
        static void Resize<T>(ref T[] array, int newSize) 
        {
            T[] newArray = new T[newSize];
            for (int i = 0; i < array.Length && i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }
        
        static void Main(string[] args)
        {
            int[] MyArray = { 1, 2, 3 };
            Resize(ref MyArray, 10);
        }
    }
}
   
using System;

namespace Example
{
    public class Point
    {
        public Point(int a, int b, char c)
        {
            x = a;
            y = b;
            sym = c;
        }
        
        
        public int x;
        public int y;
        public char sym;

        public void Draw()
        {
            Console.SetCursorPosition(x,y);
            Console.WriteLine(sym);
        }

        public static void kissmyass()
        {
            
        }
        
        
        

    }
}
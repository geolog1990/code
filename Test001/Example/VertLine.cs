using System;
using System.Collections.Generic;

namespace Example
{
    public class VertLine:Line
    {
        
        public VertLine(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                pList.Add(new Point(x, y, sym));
            } 
        }

       

    }
}
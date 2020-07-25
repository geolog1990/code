using System.Collections.Generic;

namespace Example
{
    public class HorLine:Line
    {
        public HorLine(int xleft, int xright, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xleft; x <= xright; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
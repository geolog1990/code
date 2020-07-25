using System.Collections.Generic;

namespace Example
{
    public class Line
    {
        protected List<Point> pList;
        public void Draw()
        {
            foreach (Point point in pList)
            {
                point.Draw();
            }
        }
    }
}
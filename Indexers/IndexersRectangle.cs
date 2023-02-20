using System;
using System.Collections.Generic;
using System.Drawing;

namespace Indexers
{
    public class IndexersRectangle
    {
        private Rectangle Rectangle { get; set; }

        private Dictionary<string, Point> PointList;
        public IndexersRectangle(Rectangle rectangle)
        {
            Rectangle = rectangle;

            PointList = new Dictionary<string, Point>();
        }

        public Point this[string Key]
        {
            get
            {
                return PointList[Key];
            }
            set
            {
                if (!PointList.ContainsKey(Key))
                {
                    if (Rectangle.Contains(value))
                    {
                        PointList.Add(Key, value);
                    }
                    else
                    {
                        Console.WriteLine("The point exist");
                    }
                }
            }
        }

        public void AddPoint(string name, int x, int y)
        {
            Point p = new Point(x,y);

            Rectangle NewRectangle = new Rectangle(p, ((Size)p));

            if (!PointList.ContainsKey(name))
            {
                if (Rectangle.Contains(NewRectangle))
                {
                    PointList.Add(name, p);
                }
                else
                {
                    Console.WriteLine("the point exist");
                }
            }
        }
    }
}

using System.Drawing;

namespace Indexers
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Point point = new Point(10, 10);

            Rectangle rectangle = new Rectangle(10,10,10,10);

            IndexersRectangle indexersRectangle = new IndexersRectangle(rectangle);

            indexersRectangle.AddPoint("a", 2, 3);

            indexersRectangle.AddPoint("a", 7, 3);

            indexersRectangle.AddPoint("b", 15, 15);

            indexersRectangle["c"] = new Point(6, 6);

            indexersRectangle["a"] = new Point(2, 6);

        }
    }
}

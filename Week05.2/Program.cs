using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05._2
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<IFigure> figures = new List<IFigure>();

            IFigure circle = new Circle(new Point(0, 0), 10);
            //IFigure circle2 = new Circle(new Point(0, 0), 20);
            //IFigure circle3 = new Circle(new Point(0, 0), 30);
            IFigure square = new Square(new Point(0, 0), 10);
            IFigure triangle = new Triangle(new Point(0, 0), 10, 4);
            
            figures.Add(circle);
            //figures.Add(circle2);
            //figures.Add(circle3);
            figures.Add(square);
            figures.Add(triangle);

            foreach (var figure in figures)
            {
                figure.PrintArea();
            }

            //circle.PrintArea();
            //square.PrintArea();
            //triangle.PrintArea();
        }
    }
}

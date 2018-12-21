using System;

namespace Week05._2
{
    public abstract class Figure : IFigure
    {
        public Point Point { get; }

        public Figure(Point point)
        {
            this.Point = point;
        }

        public abstract double GetArea();

        public virtual void PrintArea()
        {
            Console.WriteLine($"{this.GetFigureType()} area: {this.GetArea()}");
        }

        public abstract string GetFigureType();
    }
}
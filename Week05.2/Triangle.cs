using System;

namespace Week05._2
{
    public class Triangle : Figure
    {
        public int B { get; }

        public int H { get; }

        public Triangle(Point basePoint, int b, int h): base(basePoint)
        {
            B = b;
            H = h;
        }

        public override double GetArea()
        {
            return (double) B * H / 2;
        }

        //public void PrintArea()
        //{
        //    Console.WriteLine($"{this.GetFigureType()} area: {this.GetArea()}");
        //}

        public override string GetFigureType()
        {
            return "Triangle";
        }
    }
}
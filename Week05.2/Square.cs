using System;

namespace Week05._2
{
    public class Square : Figure
    {
        public int L { get; }

        public Square(Point basePoint, int l) : base(basePoint)
        {
            L = l;
        }

        public override double GetArea()
        {
            return L * L;
        }

        //public void PrintArea()
        //{
        //    Console.WriteLine($"{this.GetFigureType()} area: {this.GetArea()}");
        //}

        public override string GetFigureType()
        {
            return "Square";
        }
    }
}
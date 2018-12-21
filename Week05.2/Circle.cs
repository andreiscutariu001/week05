using System;

namespace Week05._2
{
    //public class CircleV2 : Circle
    //{
    //    public CircleV2(Point basePoint, int r) : base(basePoint, r)
    //    {
    //    }

    //    public override void PrintArea()
    //    {
    //        Console.WriteLine($"##### Current context circle v2: Area is {this.GetArea()}");
    //    }
    //}

    public class Circle : Figure
    {
        public int R { get; }

        public Circle(Point basePoint, int r): base(basePoint)
        {
            R = r;
        }

        public override double GetArea()
        {
            return Math.PI * R * R;
        }

        public override void PrintArea()
        {
            Console.WriteLine($"### Current context circle: Area is {this.GetArea()}");
        }

        public override string GetFigureType()
        {
            return "Circle";
        }
    }
}
using GeometryAreaCalculator.Entities.Enums;

namespace GeometryAreaCalculator.Entities
{
    internal class Square : Shape
    {
        public double Side { get; set; }

        public Square(double side, Color color) : base(color)
        {
            Side = side;
        }

        public override double Area()
        {
            return Side * Side;
        }
    }
}

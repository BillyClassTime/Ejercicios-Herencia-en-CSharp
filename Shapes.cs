
using System;
using static System.Console;
namespace Heritage05
{
    public class Square : Shape
    {
        public Square(double length)
        {
            Side = length;
        }

        public double Side { get; }                         //{get {return side;}}

        public override double Area => Math.Pow(Side, 2);   //{ get {return Math.Pow(Side, 2);}}

        public override double Perimeter => Side * 4;       // {get {return Side * 4;}}

        public double Diagonal => Math.Round(Math.Sqrt(2) * Side, 2); // {get {return Math.Round(Math.Sqrt(2) * Side, 2);}}
    }

    public class Rectangle : Shape
    {
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double Length { get; } // {get {return length;}}

        public double Width { get; }  // {get {return width;}}

        public override double Area => Length * Width; //get {return Length * Width;}

        public override double Perimeter => 2 * Length + 2 * Width; //get {return 2 * Length + 2 * Width;}

        public bool IsSquare() => Length == Width; //{ return Length== Width;}

        public double Diagonal => Math.Round(Math.Sqrt(Math.Pow(Length, 2) + Math.Pow(Width, 2)), 2);
                                    // {get{return Math.Round(Math.Sqrt(Math.Pow(Length, 2) + Math.Pow(Width, 2)), 2);}}

        public new static double GetArea(Shape shape) =>shape.Area+1;
    }

    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area => Math.Round(Math.PI * Math.Pow(Radius, 2), 2); // {get {return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);}}

        public override double Perimeter => Math.Round(Math.PI * 2 * Radius, 2); // {get {return Math.Round(Math.PI * 2 * Radius, 2);}}

        // Define a circumference, since it's the more familiar term.
        public double Circumference => Perimeter; //{get {return Perimeter;}}

        public double Radius { get; }

        public double Diameter => Radius * 2;
    }

    public class Pentagono : Shape
    {
        public Pentagono(double apotema, double side)
        {
            this.apotema=apotema;
            this.side = side;
            this.perimeter = this.side * 5;
        }
        private double apotema;
        public double Apotema { get=>apotema;  set =>apotema=value;} // {get; set;}// get {return apotema;} set {apotema=value;}
        public override double Area => (perimeter * apotema)/2; // get {return (perimeter*apotema)/2;}
        protected double perimeter;
        //public override double Perimeter=>Side*5; // {get => Side*5; set=>perimeter=value;}//set {perimeter =value;}}
        public override double Perimeter {get{
            perimeter = side*5;
            WriteLine($"Pasa por clase Pentagono; valor del perimetro:{perimeter}");
            return perimeter;
            ;}}
        private double side;
        public double Side { get=>side;  set =>side=value;} // {get {return side;} set {side = value;}}
    }

    public class PentagonoEspecializado : Pentagono
    {
        public PentagonoEspecializado(double apotema, double side)
        : base(apotema, side){
            perimeter = base.perimeter = side*5.5;
        }
        //public new double Perimeter => Side * 5.5; //{get {return Side*5.5;}}
        //public override double Area=>(perimeter*apotema)/2;
        private new double perimeter;
        public new double Perimeter {get {
            perimeter = base.Side *5.5;
            base.perimeter = perimeter;
            WriteLine($"Pasa por la clase Pentagono especializado, el valor del perimetro es:{perimeter}");
            return perimeter;
        }}
        //private double apotema;
    }
}
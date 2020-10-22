
using System;
using static System.Console;
namespace Heritage05
{
    public abstract class Shape
    {
        public abstract double Area { get; }
        //public double Area { get; }

        public abstract double Perimeter { get; }
        //public double Perimeter { get; }

        //public override string ToString() => GetType().Name;

        //public abstract void SizeDefinition();
        public override string ToString()
        {
            return GetType().Name;
        } 

        public static double GetArea(Shape shape) => shape.Area;

        public static double GetPerimeter(Shape shape) => shape.Perimeter;
    }

    public class AA{

        public static int aa1=0;
        public static void aa(){}
    }
    public class BB: AA{

    }
    public class CC
    {
        public void cc()
        {
            WriteLine(BB.aa1);
            BB.aa();
        }
    }
}
# Herencia ejercicios y practicas

## Uso de Clases bases y clases derivadas

```csharp
public class Beverage
{
    public Beverage(){}
    // ...
}     
```

```csharp
public class Coffee : Beverage
{
	// ...
}
```

```csharp
 public class Juice : Beverage
 {
	 public Juice() {}
 }
```

```csharp
public class IceJuice : Juice
{
    public IceJuice(){
        // ...
}         
```

## Clases Abstracts

```csharp
public abstract class Publication
{
    private bool published = false;
    private DateTime datePublished;
    private int totalPages;
    // ...
```

## Using virtuals, overrides and new

```csharp
	//...
	public override string ToString() => Title;
}
```

```csharp
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
```

```csharp
class Animal
{
  public virtual void Respirar()
  {
     WriteLine("Animal - Respirar");
  }
  public virtual void Correr()
  {
    Console.WriteLine("Animal - Correr");
  }
}
class Hombre : Animal
{
  public new void Correr()
  {
    WriteLine("Hombre - Correr");
  }
  public override void Respirar()
  {
    WriteLine("Hombre - Respirar");
  }
}
```

## Using Protected

```csharp
class A
{
    protected int x = 123;
}
class B : A
{
    static void Main01()
    {
        var a = new A();
        var b = new B();
        // Error CS1540, because x can only be ac
        // classes derived from A.
        // a.x = 10;
        // OK, because this class derives from A.
        b.x = 10;
    }
    void otherMethod()
    {
        var a = new A();
        var b = new B();
        //a.x = 15;
        b.x = 10;
    }
}
class C
{
}
```

### Using Sealed Class

``` csharp
public sealed class Tea : ABeverage
{
    public override int GetServingTemperature()
    {
        return 78;
    }
}
```


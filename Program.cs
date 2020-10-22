using System;
using static System.Console;
namespace Heritage05
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Program().usingNewAndOverride();
            //new Program().usingAutomobileHeritage();
            //new Program().usingPublicationHeritage();
            //new Program().usingShapesHeritage();
            //new Program().UsingBeverageHeritage();
        }
        public void UsingBeverageHeritage()
        {
            Beverage coffee = new Beverage();
            Coffee coffee1 = new Coffee();
            // Use base class members.
            coffee1.Name = "Fourth Espresso";
            coffee1.IncludeMilk = true;
            coffee1.IsFairTrade = true;
            int servingTemp = coffee1.GetServingTemperature();
            WriteLine($"Temperatura desde la clase base:{servingTemp}");
            // Use derived class members.
            coffee1.Bean = "Arabica";
            coffee1.Roast = "Dark";
            coffee1.CountryOfOrigin = "Colombia";

            servingTemp = coffee.GetServingTemperature();
            servingTemp = coffee1.OtherServingTemperatura();
            WriteLine($"Temperatura desde la clase derivada:{servingTemp}");

            Juice orange = new Juice();
            orange.Name = "Valencia";
            //orange.servingTemperature = 20;

            Expresso cafeExpreso = new Expresso();
            cafeExpreso.Name = "Fiveth Espresso";
            cafeExpreso.IncludeMilk = true;
            cafeExpreso.IsFairTrade = true;
            servingTemp = cafeExpreso.GetServingTemperature();
            WriteLine($"Temperatura en Cafe Expreso desde la clase base:{servingTemp}");

            IceJuice Naranja = new IceJuice();
            Naranja.Name = "Golden Valencian";
            Naranja.IsFairTrade = true;
            servingTemp = Naranja.GetServingTemperature();
            WriteLine($"Temperatura en Juice:{servingTemp}");
        }

        public void usingShapesHeritage()
        {
            Shape[] shapes = { new Rectangle(10, 12), new Square(5),
                        new Circle(3), new PentagonoEspecializado(3,4) };
            foreach (var shape in shapes)
            {
                WriteLine($"{shape}: area, {Shape.GetArea(shape)}; " +
                                  $"perimeter, {Shape.GetPerimeter(shape)}");
                var rect = shape as Rectangle;
                if (rect != null)
                {
                    WriteLine($"   Is Square: {rect.IsSquare()}, Diagonal: {rect.Diagonal}");
                    WriteLine($"area R:{Rectangle.GetArea(rect)}");
                    continue;
                }
                var sq = shape as Square;
                if (sq != null)
                {
                    WriteLine($"   Diagonal: {sq.Diagonal}");
                    WriteLine($"area S:{Square.GetArea(sq)}");
                    continue;
                }
                var pe = shape as PentagonoEspecializado;
                if (pe != null)
                {
                    WriteLine(new String('=',80));;
                    WriteLine($"   Perimeter(getPerimeter): {PentagonoEspecializado.GetPerimeter(pe)}");
                    WriteLine($"   Perimeter(pe): {pe.Perimeter}");
                    WriteLine($"area PE:{PentagonoEspecializado.GetArea(pe)}");
                    //continue;
                }

                var p = shape as Pentagono;
                if (p != null)
                {
                    WriteLine($"   Perimeter(getPerimeter): {Pentagono.GetPerimeter(p)}");
                    WriteLine($"   Perimeter(p): {p.Perimeter}");
                    WriteLine($"area P:{Pentagono.GetArea(p)}");
                    continue;
                }


                //Shape figura = new Shape(); No puedo instanciar clases ventajas

            }
        }

        public void usingPublicationHeritage()
        {
            var book = new Book("The Tempest", "0971655819", "Shakespeare, William",
                                "Public Domain Press");
            ShowPublicationInfo(book);
            book.Publish(new DateTime(2016, 8, 18));
            ShowPublicationInfo(book);

            var book2 = new Book("The Tempest", "Classic Works Press", "Shakespeare, William");
            Write($"{book.Title} and {book2.Title} are the same publication: " +
                  $"{((Publication)book).Equals(book2)}");
        }
        public static void ShowPublicationInfo(Publication pub)
        {
            string pubDate = pub.GetPublicationDate();
            WriteLine($"{pub.Title}, " +
                      $"{(pubDate == "NYP" ? "Not Yet Published" : "published on " + pubDate):d} by {pub.Publisher}");
        }

        public void usingAutomobileHeritage()
        {
            var packard = new Automobile("Packard", "Custom Eight", 1948);
            WriteLine(packard);
        }

        public void usingNewAndOverride()
        {
            Animal bc = new Animal();
            Hombre dc = new Hombre();

            Animal bcdc = dc; //new Hombre();

            bc.Respirar();
            bc.Correr();
            dc.Respirar();
            dc.Correr();
            bcdc.Respirar();
            bcdc.Correr();
            
            //((DerivedClass) bcdc).Correr(); //Accede al metodo porque se ha hecho la conversion
            //((DerivedClass) bc).Correr(); //Error en tiempo de ejecución de conversion

        }
    }
}
using System;
using static System.Console;
namespace Heritage05
{
    class Animal
    {
        //public void Method1()
        public virtual void Respirar()
        {
            WriteLine("Animal - Respirar");
        }

        //(2)
        //public void Method2()
        public virtual void Correr()
        {
            Console.WriteLine("Animal - Correr");
        }
    }

    class Hombre : Animal
    {
        //public void Method2()
        public new void Correr()
        {
            WriteLine("Hombre - Correr");
        }
        public override void Respirar()
        {
            //base.Method2();
            WriteLine("Hombre - Respirar");
        }
    }
}
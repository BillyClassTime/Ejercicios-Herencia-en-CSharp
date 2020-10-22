namespace Heritage05
{
    public class Coffee : Beverage
    {
        public Coffee() {}
        public string Bean { get; set; }
        public string Roast { get; set; }
        public string CountryOfOrigin { get; set; }

        //private int servingTempWithMilk;
        //private int servingTempWithoutMilk;

        public bool IncludeMilk { get; set; }
        public int ServingTempWithMilk { get; set; }
        public int ServingTempWithoutMilk { get; set; }
        //Overriding a Virtual Method by Using the override Keyword 
        public override int GetServingTemperature()
        {
            if (IncludeMilk)
                return ServingTempWithMilk = base.GetServingTemperature() + 10;
            else
                return ServingTempWithoutMilk = base.GetServingTemperature() + 15;
            //return base.GetServingTemperature();
        }

        //private bool includeMilk;
        /*public new int GetServingTemperature()
        {
            if (base.servingTemperature > 0)
            {
                includesMilk = true;
            }
            if (includesMilk)
                return servingTempWithMilk;
            else
                return servingTempWithoutMilk;
        }*/
        /*sealed public override int GetServingTemperature()
        {
            // Derived classes cannot override this method.
        }*/

        public int OtherServingTemperatura()
        {
            return base.servingTemperature;
        }
        //Coffee() :base() //Llamando al constructor de la clase Base
        /*{

        }*/
        public Coffee(string name, bool isFairTrade, int servingTemp, string bean, string roast)
                    : base(name, isFairTrade, servingTemp)
        {
            // This calls the Beverage(string, bool, int) constructor.
            // You can include additional code here:
            Bean = bean;
            Roast = roast;
        }
    }

    public class Juice : Beverage
    {
        public Juice() {}
        public Juice(string name)
        :base(name,default,default)
        {
        }
        private string RecolectarSemillas()
        {
            servingTemperature = 23;
            return "";
        }

        public new int GetServingTemperature()
        {
            return servingTemperature - 13;
        }



    }

    public class IceJuice : Juice
    {
        public IceJuice(){}
        public IceJuice(string name)
        :base(name){}
        private string SirviendoHelados()
        {
            servingTemperature = 34;
            return "";
        }
    }

    public class Expresso : Coffee
    {
        public Expresso(){}
        Expresso(string name):base(name,default,default,default,default){}

    }

}
using System;
namespace Heritage05
{
    public class Beverage
    {
        public Beverage(){}
        // Protected: El acceso está limitado a la clase contenedora o a los tipos derivados de la clase contenedora.
        protected int servingTemperature = 43;
        public string Name { get; set; }
        public bool IsFairTrade { get; set; }

        // To create a member that developers can override in a derived class, you use the virtual keyword. 
        //public int GetServingTemperature()

        public virtual int GetServingTemperature()
        {
            return servingTemperature;
        }

        public Beverage(string name, bool isFairTrade, int servingTemp)
        {
            // Implementation details are not shown.
        }
    }
}
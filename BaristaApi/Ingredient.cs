using System;
using System.Collections.Generic;
using System.Text;


namespace BaristaApi
{

    public enum CoffeeSort
    {
        Robusta,
        Arabica,
        Liberica,
        Excelsa
    }
    public enum Additive
    {
        Espresso,
        Milk,
        MilkFoam,
        ChocolateSyrup,
        Water,
    }
    public enum CoffeeType
    {
        Americano,
        Esspresso,
        Latte,
        HotChocolate        
    }
    public class Ingredient
    {
        private int _AmmountInG { get; set; }
        public CoffeeSort Sort { get; set; }

        public int AmmountInG
        {
            get { return _AmmountInG; }
            set
            {
                if (AmmountInG <= 30)
                {
                    _AmmountInG = value;
                }
                else
                {                  
                    throw new ArgumentException("The amount has to be less then or equal to : 30 g");
                }
            }
        }

    }
    public class Bean : Ingredient
    {
        
    }


}
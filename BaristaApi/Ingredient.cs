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
        Esspresso,
        Milk,
        MilkFoam,
        Chocolate,
        Water,
    }
    public enum CoffeeType
    {
        Americano,
        Esspresso,
        Latte,        
        Mocha,
        Non
        
    }
    public enum CoffeeSize
    {
        Larg,
        Medium,
        Small,
        
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
    public class Water : Ingredient
    {
        public int Temptemperatur { get; set; }
    }


}
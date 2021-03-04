using System;
using System.Collections.Generic;
using System.Text;


namespace BaristaApi
{
    public class Ingredient
    {
        public string Name { get; set; }
        public string Type { get; set; }
        private int _Amount { get; set; }


        public int Amount
        {
            get { return _Amount; }
            set
            {
                if (Amount <= 30)
                {
                    _Amount = value;
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

        public string RoastedType { get; set; }
        public string Country { get; set; }



    }


    public class Milke : Ingredient
    {
        public bool Eko { get; set; }
        public bool Normal { get; set; }
    }

    public class Water : Ingredient
    {
        public int Weight { get; set; }


    }

    public class Flavouring : Ingredient
    {
        public bool ChocolateSyrup { get; set; }
        public bool MilkFoam { get; set; }

    }


}
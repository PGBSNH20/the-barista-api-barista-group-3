using System;
using System.Collections.Generic;
using System.Text;


namespace BaristaApi
{
    public class Ingredient
    {
        public string Name { get; set; }
        //public string Type { get; set; }
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
                   
                    _Amount = 0;
                    throw new ArgumentException("The amount has to be less then or equal to : 30 g");
                }
            }
        }

    }


    public class Bean : Ingredient
    {

        public bool Coffee { get; set; }
        public bool Chocolate { get; set; }



    }


    public class Milke : Ingredient
    {
        public bool LactosFree { get; set; }
        public bool Normal { get; set; }
    }

    public class Water : Ingredient
    {
        public int Volume { get; set; }


    }

    public class Flavouring : Ingredient
    {
        public bool ChocolateSyrup { get; set; }
        public bool MilkFoam { get; set; }

    }


}
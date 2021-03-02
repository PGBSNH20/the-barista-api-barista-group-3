using System;
using System.Collections.Generic;
using System.Text;

class Ingredient
{
    public string Name { get; set; }
    public string Type { get; set; }
    private int _Amount { get; set; }


    public int Amount
    {
        get { return _Amount; }
        set
        {
            if (Amount<=30)
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


class Bean: Ingredient
{
    
    public string RoastedType { get; set; }
    public string Country { get; set; }



}


class Mike : Ingredient
{
    public bool Eko { get; set; }
    public bool Normal { get; set; }
}

class Water:Ingredient
{



}



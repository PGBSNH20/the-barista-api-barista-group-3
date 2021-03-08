using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace BaristaApi
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee a = new CoffeeMachine().CoffeeSize(1).AddBean(new Bean() { AmmountInG=4,Sort=CoffeeSort.Robusta}).GetCoffeeIngredients();

            a.PrintCaffee();

            
            //foreach (var item in a.Ingredients)
            //{
            //    Console.WriteLine(item);
            //}
        }

        

                   


    
    }
            
}


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
            Coffee a = new CoffeeMachine().AddBean(new Bean { AmmountInG=5 ,Sort= CoffeeSort.Robusta }).AddWater(5).GetCoffee();


            a.Caffee();

            
            //foreach (var item in a.Ingredients)
            //{
            //    Console.WriteLine(item);
            //}
        }

        

                   


    
    }
            
}


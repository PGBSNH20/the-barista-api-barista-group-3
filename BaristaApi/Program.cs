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
            Coffee a = new CoffeeMachine()
                   .AddBean((new Bean { Name = "Americano"}), 20)
                   .AddWater((new Water { Volume = 4 }), 5)
                   .AddMilk((new Milke { Normal = true}), 8)
                   .AddFlavouring((new Flavouring {  ChocolateSyrup = true, MilkFoam = true }), 6).GetCoffee();



            a.PrintCaffee();
            //foreach (var item in a.Ingredients)
            //{
            //    Console.WriteLine(item);
            //}
        }

        

                   


    
    }
            
}


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
                   .AddBean((new Bean { Name = "American",Type= "Medium", Country = "USA", RoastedType = "Medium", Amount=20}), 50)
                   .AddWater((new Water { Name = "Water ", Type = "normal", Weight = 4 }), 5)
                   .AddMilk((new Milke { Name = "Arla", Normal = true, Eko = false }), 8)
                   .AddFlavouring((new Flavouring { Name = "Choco ", Type = "Dark ", ChocolateSyrup = true, MilkFoam = true }), 6).GetCoffee();



            a.PrintCaffee();
            //foreach (var item in a.Ingredients)
            //{
            //    Console.WriteLine(item);
            //}
        }

        

                   


    
    }
            
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi
{
    public interface IMake
    {
        IMake AddBean(Bean bean);
        IMake AddWater(int amount);
        IMake AddMilk(int amount);
        IMake AddChocolate(int amount);      
        Coffee GetCoffee();

    }

    public  class CoffeeMachine: IMake
    {

        public Bean Bean { get; set; }
        public Ingredient Water { get; set; }
        public CoffeeSort Sort { get; set; }

        private readonly List<Additive> Ingredients = new List<Additive>();

        public IMake AddBean(Bean bean)
        {
            Bean = bean;
            Sort = bean.Sort;
            Ingredients.Add(Additive.Espresso);
            return this;
        }

        public IMake AddWater(int amount)
        {
            Ingredients.Add(Additive.Water);
            return this;
        }
 
        public IMake AddMilk( int amount)
        {           
                Ingredients.Add(Additive.Milk);
                 return this;
        }
        public IMake AddChocolate(int amount)
        {           
                Ingredients.Add(Additive.ChocolateSyrup);
                return this;          
        }
        
        public Coffee GetCoffee()
        {           
            return new Coffee(Ingredients);
        }
    }
    

    public class Coffee
    {     
        public List<Additive> Ingredients { get; set; }

        public Coffee(List<Additive> ingredients)
        {
            this.Ingredients = ingredients;

        }

        public CoffeeType PrintCaffee()
        {                      
                if (Ingredients.Contains(Additive.Espresso) && Ingredients.Contains(Additive.Water)&& Ingredients.Count==2)
                {
                    return CoffeeType.Esspresso;
                }
                else if (Ingredients.Contains(Additive.ChocolateSyrup) && Ingredients.Contains(Additive.MilkFoam) && Ingredients.Contains(Additive.Milk) && Ingredients.Count == 3)
                {
                    return CoffeeType.Americano;
                }
                else 
                {
                    return CoffeeType.Latte;
                }  
        }

        public void Caffee()
        {
            CoffeeType a = PrintCaffee();

            Console.WriteLine(a);
        }
    }

   

}

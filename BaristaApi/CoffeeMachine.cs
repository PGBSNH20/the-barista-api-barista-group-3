﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi
{
    public interface IMake
    {
        IMake CoffeeSize(int number);
        IMake AddBean(Bean bean);

        IMake AddWater(int amount,int temp=90);
        IMake AddMilk(int amount);
        IMake AddMilkFoam(int amount);
        
        IMake AddChocolate(int amount);      
        Coffee GetCoffeeIngredients();      
    }

    public  class CoffeeMachine: IMake
    {

        public Bean Bean { get; set; }
        public Water Water { get; set; }
        public CoffeeSort sort { get; set; }

        private readonly List<Additive> CoffeeIngredients = new List<Additive>();
        private readonly List<CoffeeSort> Sort = new List<CoffeeSort>();
        private readonly List<CoffeeSize> Size = new List<CoffeeSize>();
        private readonly List<string> AllIngredients = new List<string>();



        public IMake CoffeeSize(int number)
        {
            if (number==1)
            {
                Size.Add(BaristaApi.CoffeeSize.Small);
                    
            }
            else if (number==2)
            {
                Size.Add(BaristaApi.CoffeeSize.Medium);
                    
            }
            else if (number == 3)
            {
                Size.Add(BaristaApi.CoffeeSize.Larg);
            }
            return this;
        }
        public IMake AddBean(Bean bean)
        {
            Bean = bean;
            sort = bean.Sort;
            Sort.Add(sort);
            CoffeeIngredients.Add(Additive.Espresso);
            return this;
        }

        public IMake AddWater(int amount, int temp)
        {
            
            
            if (temp >=90)
            {
                CoffeeIngredients.Add(Additive.Water);
                return this;
            }
            else
            {
                throw new ArgumentException("Water is not warm enough");
            }
           
        }
 
        public IMake AddMilk( int amount)
        {           
                CoffeeIngredients.Add(Additive.Milk);
                 return this;
        }
        public IMake AddMilkFoam(int amount)
        {
            CoffeeIngredients.Add(Additive.MilkFoam);
            return this;
        }
        public IMake AddChocolate(int amount)
        {           
                CoffeeIngredients.Add(Additive.ChocolateSyrup);
                return this;          
        }

        public Coffee GetCoffeeIngredients()
        {           
            return new Coffee(GetAllInList().ToList());
        }

        public string[] GetAllInList()
        {
            for (int i = 0; i <= CoffeeIngredients.Count - 1; i++)
            {
                AllIngredients.Add(CoffeeIngredients[i].ToString());
            }
            for (int i = 0; i <= Sort.Count-1; i++)
            {
                AllIngredients.Add(Sort[i].ToString());
            }
            for (int i = 0; i <= Size.Count - 1; i++)
            {
                AllIngredients.Add(Size[i].ToString());
            }
            return AllIngredients.ToArray(); 
        }
    }
    

    public class Coffee
    {     
        public List<string> Ingredients { get; set; }

        public Coffee(List<string> ingredients)
        {
            this.Ingredients = ingredients;

        }

        public CoffeeType CaffeeType()
        {            
                if (Ingredients.Contains("Esspresso") && Ingredients.Contains("Water") && Ingredients.Count<=4)
                {
                    return CoffeeType.Esspresso;
                }               
                else if (Ingredients.Contains("Esspresso") && Ingredients.Contains("MilkFoam") && Ingredients.Contains("Milk"))
                {
                    return CoffeeType.Latte;
                }
                else if (Ingredients.Contains("Esspresso") && Ingredients.Contains("Water") && Ingredients.Contains("Milk"))
                {
                    return CoffeeType.Americano;
                }
                else
                {
                return CoffeeType.Mocha;
                }
                
        }

        public void PrintCaffee()
        {
            CoffeeType order = CaffeeType();

            foreach (var item in Ingredients)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Your order is ready : {order} :)");

            Console.WriteLine();
        }
    }

   

}

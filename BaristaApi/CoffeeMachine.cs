﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi
{
    public  class CoffeeMachine:IStart,IWater,IAdd
    {
       

        private readonly List<Ingredient> Ingredients = new List<Ingredient>();

        public IWater AddBean(Bean bean, int amount)
        {
            bean.Amount = amount;
            Ingredients.Add(bean);
            return this;
        }

        public IAdd AddWater(Water water,int amount)
        {
            water.Amount = amount;
            Ingredients.Add(water);
            return this;
        }

        public IAdd AddFlavouring(Flavouring flavouring,int amount)
        {
            flavouring.Amount = amount;
            Ingredients.Add(flavouring);

            return this;
        }
        public IAdd AddMilk(Milke milke, int amount)
        {
            milke.Amount = amount;
            Ingredients.Add(milke);
            return this;
        }
        
        public Coffee GetCoffee()
        {
            return new Coffee(Ingredients);
        }

        

    }

   public interface IStart
    {
        IWater AddBean(Bean bean,int amount);
    }
    public interface IWater
    {
        IAdd AddWater(Water water,int amount);
    }
    public interface IAdd
    {
        IAdd AddFlavouring(Flavouring flavouring,int amount);
        IAdd AddMilk(Milke milk,int amount);

        Coffee GetCoffee();
    }

    public class Coffee
    {
        public List<Ingredient> Ingredients { get; set; }
            
        public Coffee(List<Ingredient> ingredients)
        {
            this.Ingredients = ingredients;
        }

        public void PrintCaffee()
        {
            foreach (var item in Ingredients.Select(c=>c.Name+":"+c.Type+":"+c.Amount))
            {


                Console.WriteLine(item);
                //Console.WriteLine($"{item.Name}: " 
                //                + $"{item.Type}: " 
                //                + $"{item.Amount}");


            }
        }
    }

}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaristaApi;


namespace BaristaApi.Tests
{
    [TestClass]
    public class CoffeeMachinTests
    {
        [TestMethod]
        public void AddingWater_AddingCoffee_ReturnsEsspresso()
        {
            var espresso = new CoffeeMachine().CoffeeSize(1)
                .AddBean(new Bean() { AmmountInG = 5, Sort = CoffeeSort.Robusta })
                .AddWater(5)
                .GetCoffeeIngredients(); 

            Assert.AreEqual(espresso.CaffeeType().ToString(), "Esspresso");           
        }

        //[TestMethod]
        //public void AddingWater_AddingCoffee_AddingMilk_ReturnsLatte()
        //{
        //    var espresso = new CoffeeMachine().CoffeeSize(1)
        //        .AddBean(new Bean() { AmmountInG = 5, Sort = CoffeeSort.Robusta })                
        //        .AddMilk(4)
        //        .AddMilkFoam(5)
        //        .GetCoffeeIngredients();

        //    Assert.AreEqual(espresso.CaffeeType().ToString(), "Latte");
        //}
        //[TestMethod]
        //public void AddingWater_And_AddingCoffee_ReturnsEsspresso()
        //{
        //    var espresso = new CoffeeMachine().CoffeeSize(1)
        //        .AddBean(new Bean() { AmmountInG = 5, Sort = CoffeeSort.Robusta })
        //        .AddWater(5)
        //        .GetCoffeeIngredients();

        //    Assert.AreEqual(espresso.CaffeeType().ToString(), "Esspresso");
        //}
    }
}

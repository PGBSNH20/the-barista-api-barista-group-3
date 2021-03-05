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

            var Type = espresso.CaffeeType().ToString();

            Assert.AreEqual(Type, "Esspresso");           
        }

        [TestMethod]
        public void AddingMilk_AddingEsspresso_AddingMilkFoam_ReturnsLatte()
        {
            var espresso = new CoffeeMachine().CoffeeSize(1)
                .AddBean(new Bean() { AmmountInG = 5, Sort = CoffeeSort.Robusta })
                .AddMilk(4)
                .AddMilkFoam(5)
                .GetCoffeeIngredients();

            var Type = espresso.CaffeeType().ToString();

            Assert.AreEqual(Type, "Latte");
        }

        [TestMethod]
        public void AddingEsspresso_AddingWater_AddingMilk_ReturnsAmericano()
        {
            var espresso = new CoffeeMachine().CoffeeSize(1)
                .AddBean(new Bean() { AmmountInG = 5, Sort = CoffeeSort.Robusta })
                .AddWater(4)
                .AddMilk(5)
                .GetCoffeeIngredients();

            var Type = espresso.CaffeeType().ToString();

            Assert.AreEqual(Type, "Americano");
        }

        [TestMethod]
        public void AddingEsspresso_AddingChocolate_AddingMilk_ReturnsMocha()
        {
            var espresso = new CoffeeMachine().CoffeeSize(1)
                .AddBean(new Bean() { AmmountInG = 5, Sort = CoffeeSort.Robusta })
                .AddChocolate(4)
                .AddMilk(5)
                .GetCoffeeIngredients();

            var Type = espresso.CaffeeType().ToString();

            Assert.AreEqual(Type, "Mocha");
        }

        [TestMethod]
        public void Adding_FromOutSide_OurList_ReturnsNon()
        {
            var espresso = new CoffeeMachine().CoffeeSize(1)
                .AddBean(new Bean() { AmmountInG = 5, Sort = CoffeeSort.Robusta })
                .AddChocolate(4)
                .AddMilk(5)
                .AddWater(5)
                .AddMilkFoam(5)
                .GetCoffeeIngredients();

            var Type = espresso.CaffeeType().ToString();

            Assert.AreEqual(Type, "Non");
        }
    }
}

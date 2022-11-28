using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachine
{
    // Base ingredient, will be always in coffee
    public class WaterAndCoffeeSeeds : CoffeeIngredient
    {
        public WaterAndCoffeeSeeds() : base("Water and Coffee seeds", 10) { }
    }
}

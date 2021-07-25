using System.Collections.Generic;

namespace HotDrinksMachine
{
    /// <summary>
    /// The DrinkEngine manages the process of making a selected drink. 
    /// It delegates out the work of creating the chosen drink to the 
    /// DrinkFactory and then returns the recipe to the client.
    /// </summary>
    public class DrinkEngine
    {
        public IDrinkContext Context { get; set; } = new DefaultDrinkContext();

        public DrinkEngine()
        {
            Context.Engine = this;
        }

        public List<string> Create(string drinkType)
        {
            Drink drink = Context.CreateDrink(drinkType, Context);

            return drink.Recipe();

        }
    }
}
using System.Collections.Generic;

namespace HotDrinksMachine
{
    public class CoffeeDrink : Drink
    {
        public CoffeeDrink(IDrinkContext context) : base(context)
        {
        }

        public override List<string> Recipe()
        {
            List<string> recipe = new List<string>()
            {
                "Boil some water",
                "Brew the coffee grounds",
                "Pour coffee in the cup",
                "Add sugar and milk",
            };

            return recipe;
        }
    }
}
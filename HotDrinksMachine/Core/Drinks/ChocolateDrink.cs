using System.Collections.Generic;

namespace HotDrinksMachine
{
    public class ChocolateDrink : Drink
    {
        public ChocolateDrink(IDrinkContext context) : base(context)
        {
        }

        public override List<string> Recipe()
        {
            List<string> recipe = new List<string>()
            {
                "Boil some water",
                "Add drinking chocolate powder to the water",
                "Pour chocolate in the cup",
            };

            return recipe;
        }
    }
}
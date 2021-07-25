using System.Collections.Generic;

namespace HotDrinksMachine
{
    public class LemonTeaDrink : Drink
    {
        public LemonTeaDrink(IDrinkContext context) : base(context)
        {
        }

        public override List<string> Recipe()
        {
            List<string> recipe = new List<string>()
            {
                "Boil some water",
                "Steep the water in the tea",
                "Pour tea in the cup",
                "Add lemon",
            };

            return recipe;
        }
    }
}
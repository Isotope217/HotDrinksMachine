using System.Collections.Generic;

namespace HotDrinksMachine
{
    public class UnknownDrink : Drink
    {
        public UnknownDrink(IDrinkContext context) : base(context)
        {
        }

        public override List<string> Recipe()
        {
            List<string> recipe = new List<string>()
            {
                "Unknown drink type",
            };

            return recipe;
        }
    }
}
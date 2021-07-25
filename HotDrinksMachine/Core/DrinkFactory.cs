using System;

namespace HotDrinksMachine
{
    public class DrinkFactory
    {
        public Drink Create(string type, IDrinkContext context)
        {
            try
            {
                return (Drink)Activator.CreateInstance(
                    Type.GetType($"HotDrinksMachine.{type}Drink"),
                        new object[] { context });
            }
            catch
            {
                return new UnknownDrink(context);
            }
        }
    }
}
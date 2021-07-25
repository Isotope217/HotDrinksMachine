namespace HotDrinksMachine
{
    public class DefaultDrinkContext : IDrinkContext
    {
        public DrinkEngine Engine { get; set; }

        public Drink CreateDrink(string type, IDrinkContext context)
        {
            return new DrinkFactory().Create(type, context);
        }

    }
}
namespace HotDrinksMachine
{
    /// <summary>
    /// The DrinkEngine manages the process of making a selected drink. 
    /// It delegates out the work of creating the chosen drink to the 
    /// DrinkFactory and then returns a formatted recipe string to the client.
    /// </summary>
    public class DrinkEngine
    {
        public IDrinkContext Context { get; set; } = new DefaultDrinkContext();

        public DrinkEngine()
        {
            Context.Engine = this;
        }

        public string Create(string drinkType)
        {
            Drink drink = Context.CreateDrink(drinkType, Context);

            return string.Join(", ", drink.Recipe());

        }
    }
}
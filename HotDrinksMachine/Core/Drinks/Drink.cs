using System.Collections.Generic;

namespace HotDrinksMachine
{
    public abstract class Drink
    {
        protected readonly IDrinkContext _context;

        public Drink(IDrinkContext context)
        {
            _context = context;
        }

        public abstract List<string> Recipe();

    }
}
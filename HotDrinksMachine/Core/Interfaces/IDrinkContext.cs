using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotDrinksMachine
{
    public interface IDrinkContext
    {
        DrinkEngine Engine { get; set; }

        Drink CreateDrink(string type, IDrinkContext context);

    }
}

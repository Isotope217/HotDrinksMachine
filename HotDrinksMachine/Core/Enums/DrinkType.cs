using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotDrinksMachine.Core.Enums
{
    public enum DrinkType
    {
        [Description("Not set")]
        Notset = 0,

        [Description("Lemon Tea")]
        LemonTea = 1,

        [Description("Coffee")]
        Coffee = 2,

        [Description("Hot Chocolate")]
        Chocolate =3,

        [Description("Tea")]
        Tea = 4,
    }
}
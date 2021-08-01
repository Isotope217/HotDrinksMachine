using HotDrinksMachine.Core.Enums;
using HotDrinksMachine.Extensions;
using System;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HotDrinksMachine
{
    public partial class DrinkMachine : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                SetDrinkOptions();
            }
        }

        protected void Page_prerender(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                if (!string.IsNullOrEmpty(Enum.GetName(typeof(DrinkType), selectedDrink)) && selectedDrink != DrinkType.Notset)
                {
                    SelectedDrinkPH.Visible = true;
                    SetSelectedDrink();
                }
            }
        }

        private void SetDrinkOptions()
        {
            ErrorAlert.Text = ERROR;

            LemonTeaButton.CommandName = DrinkType.LemonTea.ToString();
            LemonTeaLable.Text = DrinkType.LemonTea.GetDescription();
            CoffeeButton.CommandName = DrinkType.Coffee.ToString();
            CoffeeLabel.Text = DrinkType.Coffee.GetDescription();
            ChocolateButton.CommandName = DrinkType.Chocolate.ToString();
            ChocolateLabel.Text = DrinkType.Chocolate.GetDescription();

        }

        private void SetSelectedDrink()
        {
            SelecteDrink.Text = selectedDrink.GetDescription();
            SuccessAlert.Text = string.Format("Your {0} is ready.", selectedDrink.GetDescription());
        }

        protected void DrinkSelection_Click(object sender, EventArgs e)
        {
            string drink = ((LinkButton)sender).CommandName;

            selectedDrink = (DrinkType)Enum.Parse(typeof(DrinkType), drink);

            DrinkEngine engine = new DrinkEngine();

            var jsonSerialiser = new JavaScriptSerializer();
            Recipe = jsonSerialiser.Serialize(engine.Create(drink));

        }

        private DrinkType selectedDrink;

        public string Recipe { get; set; }
        public const string ERROR = "Unable to make drink";


    }
}
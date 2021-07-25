using System;
using System.Web.UI;

namespace HotDrinksMachine
{
    public partial class DrinkMachine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Page.IsPostBack)
            {

                DrinkEngine engine = new DrinkEngine();
                ResultLabel.Text = engine.Create(DrinkRBList.SelectedValue);

            }
        }
    }
}
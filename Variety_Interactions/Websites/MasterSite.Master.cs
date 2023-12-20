using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Variety_Interactions.Websites
{
    public partial class MasterSite : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void HomePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void MoneyEx_Click(object sender, EventArgs e)
        {
            Response.Redirect("MoneyExchange_page.aspx");
        }

        protected void WorldTime_Click(object sender, EventArgs e)
        {
            Response.Redirect("World_Clock.aspx");
        }

        protected void BMI_Click(object sender, EventArgs e)
        {
            Response.Redirect("BMI_Status.aspx");
        }
    }
}
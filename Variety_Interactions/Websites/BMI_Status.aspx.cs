using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Variety_Interactions.Websites
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Form.DefaultButton = Calculate_BTN.UniqueID;
        }

        protected void Calculate_BTN_Click(object sender, EventArgs e)
        {
           
            try
            {
                // Converting feet and inches to total inches
                int feet = Convert.ToInt32(ft_measureID.Text);
                int inches = Convert.ToInt32(inch_measureID.Text);
                int total_inches = (feet * 12) + inches;
                double weight = Convert.ToDouble(Weight_ID.Text);

                //Formula to finding BMI
                double total_BMI = (weight / Math.Pow(total_inches, 2)) * 703;

                //formating for it prints only 1 decimal places
                string formated_BMI = total_BMI.ToString("0.0");

                BMI_Check(total_BMI, formated_BMI);
            }
            catch //if input left blank
            {
                Output_ID.ForeColor = System.Drawing.Color.Red;
                Output_ID.Text = "Missing Input";
            }
        }

        private void BMI_Check(in double final_BMI, in string final_bmi)
        {
            string statement_val = "";

            if (final_BMI < 18.5) //underweight
            {
                statement_val = "You are underweight";
                Output_ID.ForeColor = System.Drawing.ColorTranslator.FromHtml("#9627d8");
            }
            else if (final_BMI >= 18.5 && final_BMI <= 24.9) // normal weight
            {
                statement_val = "You are in normal weight";
                Output_ID.ForeColor = System.Drawing.Color.ForestGreen;
            }
            else if (final_BMI >= 25 && final_BMI <= 29.9) // overweight
            {
                statement_val = "You are overweight";
                Output_ID.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ff5f5f");
            }
            else //Obesity
            {
                statement_val = "You are obese";
                Output_ID.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ff0400");
            }

            Output_ID.Text = $"Your BMI is {final_bmi}<br>{statement_val}";

        }
    }
}
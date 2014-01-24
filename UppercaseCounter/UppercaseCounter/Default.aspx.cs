using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UppercaseCounter
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ResetButton_Click(object sender, EventArgs e)
        {
            UppercaseCount.Visible = false;
            UppercaseInput.Text = "";
            UppercaseInput.Enabled = true;
            ResetButton.Visible = false;
            CalculateButton.Visible = true;
        }

        protected void CalculateButton_Click(object sender, EventArgs e)
        {
            string inputText = UppercaseInput.Text;
            int numberOfCapitals = TextAnalyzer.GetNumberOfCapitals(inputText);

            UppercaseCount.Text = "Texten innehåller " + numberOfCapitals.ToString() + " versaler";
            UppercaseCount.Visible = true;
            UppercaseInput.Enabled = false;
            CalculateButton.Visible = false;
            ResetButton.Visible = true;
        }
    }
}
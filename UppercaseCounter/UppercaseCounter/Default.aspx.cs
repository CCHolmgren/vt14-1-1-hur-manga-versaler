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

        protected void SendButton_Click(object sender, EventArgs e)
        {
            string inputText = UppercaseInput.Text;
            int numberOfCapitals = TextAnalyzer.GetNumberOfCapitals(inputText);
            Label1.Text = "Texten innehåller " + numberOfCapitals.ToString() + " versaler";
            Label1.Visible = true;
        }
    }
}
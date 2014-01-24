using _1DV406_S1_L1._1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1DV406_S1_L1._1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            if (ResultLabel.Visible == false)
            {
                TextBox.Enabled = false;
                ResultLabel.Text = "Texten innehåller " + TextAnalyser.GetNumberOfCapitals(TextBox.Text) + " versaler.";
                Button.Text = "Rensa";
                ResultLabel.Visible = true;
            }
            else
            {
                ResultLabel.Visible = false;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeConditionalRadioButton
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            if (pencilRadioButton.Checked)
            {
                resultLabel.Text = "Pencil";
                noteImage.ImageUrl = "~/assets/pencil.png";
            }
            else if (penRadioButton.Checked)
            {
                resultLabel.Text = "Pen";
                noteImage.ImageUrl = "~/assets/pen.png";
            }
            else if (phoneRadioButton.Checked)
            {
                resultLabel.Text = "Phone";
                noteImage.ImageUrl = "~/assets/phone.png";
            }
            else if (tabletRadioButton.Checked)
            {
                resultLabel.Text = "Tablet";
                noteImage.ImageUrl = "~/assets/tablet.png";
            }
            else
            {
                resultLabel.Text = "Please make a selection";
            }
        }
    }
}
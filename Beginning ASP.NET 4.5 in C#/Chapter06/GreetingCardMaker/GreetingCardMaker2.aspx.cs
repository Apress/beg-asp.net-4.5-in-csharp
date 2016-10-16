using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Drawing.Text;

namespace GreetingCardMaker
{
	public partial class GreetingCardMaker2 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			if (this.IsPostBack == false)
			{
				// Get the list of colors.
				string[] colorArray = Enum.GetNames(typeof(KnownColor));
				lstBackColor.DataSource = colorArray;
				lstBackColor.DataBind();

				lstForeColor.DataSource = colorArray;
				lstForeColor.DataBind();
				lstForeColor.SelectedIndex = 34;
				lstBackColor.SelectedIndex = 163;

				// Get the list of available fonts and add them to the font list.
				InstalledFontCollection fonts = new InstalledFontCollection();
				foreach (FontFamily family in fonts.Families)
				{
					lstFontName.Items.Add(family.Name);
				}				

				// Set border style options.
				string[] borderStyleArray = Enum.GetNames(typeof(BorderStyle));
				lstBorder.DataSource = borderStyleArray;
				lstBorder.DataBind();
				
				// Select the first border option.
				lstBorder.SelectedIndex = 0;

				// Set the picture.
				imgDefault.ImageUrl = "defaultpic.png";
			}
		}

        private void UpdateCard()
		{
			// Update the color.
			pnlCard.BackColor = Color.FromName(lstBackColor.SelectedItem.Text);
			lblGreeting.ForeColor = Color.FromName(lstForeColor.SelectedItem.Text);

			// Update the font.
			lblGreeting.Font.Name = lstFontName.SelectedItem.Text;
			try
			{
				if (Int32.Parse(txtFontSize.Text) > 0)
				{
					lblGreeting.Font.Size = FontUnit.Point(Int32.Parse(txtFontSize.Text));
				}
			}
			catch
			{
				// Ignore invalid value.
			}

			try
			{
				if (Int32.Parse(txtFontSize.Text) > 0)
				{
					lblGreeting.Font.Size =
						FontUnit.Point(Int32.Parse(txtFontSize.Text));
				}
			}
			catch
			{
				// Ignore invalid value.
			}

			// Find the appropriate TypeConverter for the BorderStyle enumeration.
			TypeConverter cnvrt = TypeDescriptor.GetConverter(typeof(BorderStyle));

			// Update the border style using the value from the converter.
			pnlCard.BorderStyle = (BorderStyle)cnvrt.ConvertFromString(
				lstBorder.SelectedItem.Text);


			// Update the picture.
			if (chkPicture.Checked == true)
			{
				imgDefault.Visible = true;
			}
			else
			{
				imgDefault.Visible = false;
			}

			// Set the text.
			lblGreeting.Text = txtGreeting.Text;
		}

		protected void ControlChanged(Object sender, EventArgs e)
		{
            // Refresh the greeting card (because a control was changed).
            UpdateCard();
		}

        protected void cmdUpdate_Click(object sender, EventArgs e)
        {
            // Refresh the greeting card (because the button was clicked).
            UpdateCard();
        }        
	}

}

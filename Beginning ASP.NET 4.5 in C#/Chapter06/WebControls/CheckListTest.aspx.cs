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

namespace WebControls
{

	public partial class CheckBoxTest : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			if (this.IsPostBack == false)
			{
				chklst.Items.Add("C");
				chklst.Items.Add("C++");
				chklst.Items.Add("C#");
				chklst.Items.Add("Visual Basic 6.0");
				chklst.Items.Add("VB.NET");
				chklst.Items.Add("Pascal");
			}
		}
		

		protected void cmdOK_Click(object sender, System.EventArgs e)
		{
			lblResult.Text = "You chose:<b>";

			foreach (ListItem lstItem in chklst.Items)
			{
				if (lstItem.Selected == true)
				{
					// Add text to label.
					lblResult.Text += "<br />" + lstItem.Text;
				}
			}

			lblResult.Text += "</b>";
		}
	}
}

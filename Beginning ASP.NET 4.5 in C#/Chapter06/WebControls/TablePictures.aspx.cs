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
	public partial class TablePictures : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// Configure the table's appearance.
			// This could also be performed in the .aspx file,
			// or in the cmdCreate_Click event handler.
			tbl.BorderStyle = BorderStyle.Inset;
			tbl.BorderWidth = Unit.Pixel(1);
		}

		protected void cmdCreate_Click(object sender, System.EventArgs e)
		{
			// Remove all the current rows and cells.
			// This is not necessary if EnableViewState is set to false.
			tbl.Controls.Clear();

			int rows = Int32.Parse(txtRows.Text);
			int cols = Int32.Parse(txtCols.Text);
			
			for (int i = 0; i < rows; i++)
			{
				// Create a new TableRow object.
				TableRow rowNew = new TableRow();

				// Put the TableRow in the Table.
				tbl.Controls.Add(rowNew);

				for (int j = 0; j < cols; j++)
				{
					// Create a new TableCell object.
					TableCell cellNew = new TableCell();

					// Create a new Label object.
					Label lblNew = new Label();
					lblNew.Text = "Example Cell (" + i.ToString() + "," + j.ToString() + ")<br />";

					System.Web.UI.WebControls.Image imgNew = new System.Web.UI.WebControls.Image();
					imgNew.ImageUrl = "cellpic.png";

					// Put the label and picture in the cell.
					cellNew.Controls.Add(lblNew);
					cellNew.Controls.Add(imgNew);

					if (chkBorder.Checked == true)
					{
						cellNew.BorderStyle = BorderStyle.Inset;
					    cellNew.BorderWidth = Unit.Pixel(1);
				    }

					// Put the TableCell in the TableRow.
					rowNew.Controls.Add(cellNew);
				}
			}

		}
	}
}

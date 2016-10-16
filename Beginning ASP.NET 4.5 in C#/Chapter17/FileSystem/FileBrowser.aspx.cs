using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Text;

public partial class FileBrowser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            string startingDir = @"c:\";
            lblCurrentDir.Text = startingDir;
            ShowFilesIn(startingDir);
            ShowDirectoriesIn(startingDir);
        }
    }

    private void ShowFilesIn(string dir)
    {
        lblFileInfo.Text = "";
        lstFiles.Items.Clear();
        try
        {
            DirectoryInfo dirInfo = new DirectoryInfo(dir);
            foreach (FileInfo fileItem in dirInfo.GetFiles())
            {
                lstFiles.Items.Add(fileItem.Name);
            }
        }
        catch (Exception err)
        {
            // Ignore the error and leave the list box empty.
        }
    }

    private void ShowDirectoriesIn(string dir)
    {
        lstDirs.Items.Clear();
        try
        {
            DirectoryInfo dirInfo = new DirectoryInfo(dir);
            foreach (DirectoryInfo dirItem in dirInfo.GetDirectories())
            {
                lstDirs.Items.Add(dirItem.Name);
            }
        }
        catch (Exception err)
        {
            // Ignore the error and leave the list box empty.
        }
    }



    protected void cmdBrowse_Click(object sender, EventArgs e)
    {
        // Browse to the currently selected subdirectory.
        if (lstDirs.SelectedIndex != -1)
        {
            string newDir = Path.Combine(lblCurrentDir.Text,
              lstDirs.SelectedItem.Text);
            lblCurrentDir.Text = newDir;
            ShowFilesIn(newDir);
            ShowDirectoriesIn(newDir);
        }

    }
    protected void cmdParent_Click(object sender, EventArgs e)
    {
        // Browse up to the current directory's parent.
        // The Directory.GetParent() method helps us out.
        if (Directory.GetParent(lblCurrentDir.Text) == null)
        {
            // This is the root directory; there are no more levels.
        }
        else
        {
            string newDir = Directory.GetParent(lblCurrentDir.Text).FullName;
            lblCurrentDir.Text = newDir;
            ShowFilesIn(newDir);
            ShowDirectoriesIn(newDir);
        }

    }
    protected void cmdShowInfo_Click(object sender, EventArgs e)
    {
        // Show information for the currently selected file.
        if (lstFiles.SelectedIndex != -1)
        {
            string fileName = Path.Combine(lblCurrentDir.Text,
              lstFiles.SelectedItem.Text);

            StringBuilder displayText = new StringBuilder();
            try
            {
                FileInfo selectedFile = new FileInfo(fileName);
                displayText.Append("<b>");
                displayText.Append(selectedFile.Name);
                displayText.Append("</b><br />Size: ");
                displayText.Append(selectedFile.Length);
                displayText.Append("<br />");
                displayText.Append("Created: ");
                displayText.Append(selectedFile.CreationTime.ToString());
                displayText.Append("<br />Last Accessed: ");
                displayText.Append(selectedFile.LastAccessTime.ToString());
            }
            catch (Exception err)
            {
                displayText.Append(err.Message);
            }

            lblFileInfo.Text = displayText.ToString();
        }
    }

}

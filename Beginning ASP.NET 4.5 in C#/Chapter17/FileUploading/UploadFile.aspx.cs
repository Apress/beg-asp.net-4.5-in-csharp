using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;

public partial class UploadFile : System.Web.UI.Page 
{
    private string uploadDirectory;
    protected void Page_Load(object sender, EventArgs e)
    {
        uploadDirectory = Path.Combine(Request.PhysicalApplicationPath, "Uploads");
    }
    

    protected void cmdUpload_Click(object sender, EventArgs e)
    {
        // Check that a file is actually being submitted.
        if (Uploader.PostedFile.FileName == "")
        {
            lblInfo.Text = "No file specified.";
        }
        else
        {
            // Check the extension.
            string extension = Path.GetExtension(Uploader.PostedFile.FileName);
            switch (extension.ToLower())
            {
                case ".bmp":
                case ".gif":
                case ".jpg":
                    break;
                default:
                    lblInfo.Text = "This file type is not allowed.";
                    return;
            }
            // Using this code, the saved file will retain its original
            // file name, but be stored in the current server
            // application directory.
            string serverFileName = Path.GetFileName(
              Uploader.PostedFile.FileName);
            string fullUploadPath = Path.Combine(uploadDirectory,
              serverFileName);

            try
            {
                // This overwrites any existing file with the same name.
                // Use File.Exists() to check first if this is a concern.
                Uploader.PostedFile.SaveAs(fullUploadPath);

                lblInfo.Text = "File " + serverFileName;
                lblInfo.Text += " uploaded successfully to ";
                lblInfo.Text += fullUploadPath;
            }
            catch (Exception err)
            {
                lblInfo.Text = err.Message;
            }
        }
    }


}

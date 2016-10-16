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
using System.Collections.Generic;
using System.IO;

public partial class GuestBook : System.Web.UI.Page
{
    private string guestBookName;

    protected void Page_Load(object sender, EventArgs e)
    {
        guestBookName = Server.MapPath("~/App_Data/GuestBook");

        if (!this.IsPostBack)
        {
            GuestBookList.DataSource = GetAllEntries();
            GuestBookList.DataBind();
        }
    }

    private List<BookEntry> GetAllEntries()
    {
        // Return an ArrayList that contains BookEntry objects
        // for each file in the GuestBook directory.
        // This method relies on the GetEntryFromFile() method.
        List<BookEntry> entries = new List<BookEntry>();

        try
        {
            DirectoryInfo guestBookDir = new DirectoryInfo(guestBookName);
            foreach (FileInfo fileItem in guestBookDir.GetFiles())
            {
                try
                {
                    entries.Add(GetEntryFromFile(fileItem));
                }
                catch (Exception err)
                {
                    // An error occurred when calling GetEntryFromFile().
                    // Ignore this file because it can't be read.
                }
            }
        }
        catch (Exception err)
        {
            // An error occurred when calling GetFiles().
            // Ignore this error and leave the entries collection empty.
        }
        return entries;
    }


    private BookEntry GetEntryFromFile(FileInfo entryFile)
    {
        // Turn the file information into a Book Entry object.
        BookEntry newEntry = new BookEntry();
        StreamReader r = entryFile.OpenText();
        newEntry.Author = r.ReadLine();
        newEntry.Submitted = DateTime.Parse(r.ReadLine());
        newEntry.Message = r.ReadToEnd();
        r.Close();

        return newEntry;
    }

    private void SaveEntry(BookEntry entry)
    {
        // Create a new file for this entry, with a file name that should
        // be statistically unique.
        Random random = new Random();
        string fileName = guestBookName + @"\";
        fileName += DateTime.Now.Ticks.ToString() + random.Next(100).ToString();
        FileInfo newFile = new FileInfo(fileName);
        StreamWriter w = newFile.CreateText();

        // Write the information to the file.
        w.WriteLine(entry.Author);
        w.WriteLine(entry.Submitted.ToString());
        w.WriteLine(entry.Message);
        w.Flush();
        w.Close();
    }


    protected void cmdSubmit_Click(Object sender, EventArgs e)
    {
        // Create a new BookEntry object.
        BookEntry newEntry = new BookEntry();
        newEntry.Author = txtName.Text;
        newEntry.Submitted = DateTime.Now;
        newEntry.Message = txtMessage.Text;

        // Let the SaveEntry procedure create the corresponding file.
        try
        {
            SaveEntry(newEntry);
        }
        catch (Exception err)
        {
            // An error occurred. Notify the user and don't clear the 
            // display.
            lblError.Text = err.Message + " File not saved.";
            return;
        }

        // Refresh the display.
        GuestBookList.DataSource = GetAllEntries();
        GuestBookList.DataBind();
        txtName.Text = "";
        txtMessage.Text = "";
    }

}

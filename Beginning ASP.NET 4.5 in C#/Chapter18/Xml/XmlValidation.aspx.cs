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
using System.Xml.Schema;
using System.IO;
using System.Xml;

public partial class XmlValidation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
	protected void cmdValidate_Click(object sender, EventArgs e)
	{
		string filePath = Request.PhysicalApplicationPath + @"\App_Data\";
		if (optValid.Checked)
		{
			filePath += "SuperProProductList.xml";
		}
		else if (optInvalidData.Checked)
		{
			filePath += "InvalidData.xml";
		}
		else if (optInvalidTag.Checked)
		{
			filePath += "InvalidTag.xml";
		}

		lblStatus.Text = "";

		// Set the validation settings.
		XmlReaderSettings settings = new XmlReaderSettings();
        settings.Schemas.Add("http://www.SuperProProducts.com/SuperProProductList",
		  Request.PhysicalApplicationPath + @"\App_Data\SuperProProductList.xsd");
		settings.ValidationType = ValidationType.Schema;
		settings.ValidationEventHandler += new ValidationEventHandler(ValidateHandler);

		// Open the XML file.
		FileStream fs = new FileStream(filePath, FileMode.Open);
		
		// Create the validating reader.
		XmlReader r = XmlReader.Create(fs, settings);

        // Read through the document.
		while (r.Read())
		{
			// Process document here.
			// If an error is found, an exception will be thrown.
		}
		fs.Close();

		lblStatus.Text += "<br />Complete.";
	}

	public void ValidateHandler(Object sender, ValidationEventArgs e)
	{
		lblStatus.Text += "Error: " + e.Message + "<br />";
	}
}

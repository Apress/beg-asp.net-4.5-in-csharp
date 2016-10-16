using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml.Linq;

public partial class XDocumentTest : System.Web.UI.Page
{
    private string file;
    protected void Page_Load(object sender, EventArgs e)
    {
        file = Path.Combine(Request.PhysicalApplicationPath, @"App_Data\SuperProProductList_NoNamespace.xml");
    }

    protected void cmdCreateXml_Click(object sender, EventArgs e)
    {
        // Build the XML content in memory.
        XDocument doc = new XDocument(
            new XDeclaration("1.0", null, "yes"),
            new XComment("Created with the XDocument class."),
            new XElement("SuperProProductList",
                new XElement("Product",
                    new XAttribute("ID", 1),
                    new XAttribute("Name", "Chair"),
                    new XElement("Price", 49.33)
                ),
                new XElement("Product",
                    new XAttribute("ID", 2),
                    new XAttribute("Name", "Car"),
                    new XElement("Price", 43399.55)
                ),
                new XElement("Product",
                    new XAttribute("ID", 3),
                    new XAttribute("Name", "Fresh Fruit Basket"),
                    new XElement("Price", 49.99)
                )
            )
        );

        // Save the document.
        doc.Save(file);

        lblXml.Text = @"File " + file + " written successfully.";
        
    }

    protected void cmdReadXml_Click(object sender, EventArgs e)
    {
        // Load the document.
        XDocument doc = XDocument.Load(file);

        // Loop through all the nodes, and create the list of Product objects .
        List<Product> products = new List<Product>();

        foreach (XElement element in doc.Element("SuperProProductList").Elements("Product"))
        {
            Product newProduct = new Product();
            newProduct.ID = (int)element.Attribute("ID");
            newProduct.Name = (string)element.Attribute("Name");
                        
            newProduct.Price = (decimal)element.Element("Price");
            products.Add(newProduct);
        }

        // Display the results.
        gridResults.DataSource = products;
        gridResults.DataBind();
    }

    protected void cmdSearchXml_Click(object sender, EventArgs e)
    {
        XDocument doc = XDocument.Load(file);

        // Find the matches.
        var results = doc.Descendants("Price");

        // Display the results.
        lblXml.Text = "<b>Found " + results.Count().ToString() + " Matches ";
        lblXml.Text += " for the Price tag: </b><br /><br />";
        foreach (XElement result in results)
        {
            lblXml.Text += result.Value + "<br />";
        }

    }
}
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

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected string GetDescriptionFromTitle(string title)
    {
        // This assumes there's only one node with this title.
        SiteMapNode startingNode = SiteMap.RootNode;
        SiteMapNode matchNode = SearchNodes(startingNode, title);
        if (matchNode == null)
        {
            return null;
        }
        else
        {
            return matchNode.Description;
        }
    }

    private SiteMapNode SearchNodes(SiteMapNode node, string title)
    {
        if (node.Title == title)
        {
            return node;
        }
        else
        {
            // Perform recursive search.
            foreach (SiteMapNode child in node.ChildNodes)
            {
                SiteMapNode matchNode = SearchNodes(child, title);
                // Was a match found?
                // If so, return it.
                if (matchNode != null) return matchNode;
            }
            // All the nodes were examined, but no match was found.
            return null;
        }
    }


}

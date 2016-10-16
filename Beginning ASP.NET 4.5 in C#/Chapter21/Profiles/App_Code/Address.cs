using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

[Serializable()]
public class Address
{	
	public string Name {get; set;}
	public string Street {get; set;}	
	public string City {get; set;}
    public string ZipCode { get; set; }	
	public string State {get; set;}
	public string Country {get; set;}
	
	public Address(string name, string street, string city,
		string zipCode, string state, string country)
	{
		Name = name;
		Street = street;
		City = city;
		ZipCode = zipCode;
		State = state;
		Country = country;
	}

	public Address() { }
}

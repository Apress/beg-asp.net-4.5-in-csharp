using System;

// Define the delegate that represents the event.
public delegate void PriceChangedEventHandler();

public class Product
{    
    public string Name {get; set;}
    
    // Define the event.
    public event PriceChangedEventHandler PriceChanged;

    private decimal price;
    public decimal Price
    {
        get
        {
            return price;
        }
        set
        {
            price = value;

            // Fire the event, provided there is at least one listener.
            if (PriceChanged != null)
            {
                PriceChanged();
            }
        }
    }

    public string ImageUrl {get; set;}
    
    public string GetHtml()
    {
        string htmlString;
        htmlString = "<h1>" + Name + "</h1><br>";
        htmlString += "<h3>Costs: " + Price.ToString() + "</h3><br>";
        htmlString += "<img src='" + ImageUrl + "' />";
        return htmlString;
    }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public Product(string name, decimal price, string imageUrl)
    {
        Name = name;
        Price = price;
        ImageUrl = imageUrl;
    }
}


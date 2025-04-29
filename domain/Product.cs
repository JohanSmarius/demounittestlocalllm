using CommunityToolkit.Diagnostics;

namespace domain;

public class Product
{
    private decimal price;
    private string name;

    public required string Name
    {
        get => name; 
        set
        {
            Guard.IsGreaterThanOrEqualTo(value.Length, 3, nameof(Name));
            Guard.IsFalse(char.IsDigit(value[0]), nameof(Name), "Name cannot start with a number");
    
            name = value;
        }
    }
    

    public decimal Price 
    { 
        get => price; 
        set
        {
            Guard.IsGreaterThan(value, 0, nameof(Price));
            price = value;
        } 
    }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public string GetProductInfo()
    {
        return $"Product: {Name}, Price: {Price:C}";
    }
}

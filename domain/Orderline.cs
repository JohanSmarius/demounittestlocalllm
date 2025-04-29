using CommunityToolkit.Diagnostics;
using domain;

public class Orderline
{
    private int quantity;

    public int OrderlineId { get; set; }
    public int Quantity { 
        get => quantity; 
        set
        {
            Guard.IsGreaterThan(value, 0, nameof(Quantity));
            quantity = value; 
        }
    }

    public Orderline(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }
    
    public Product Product { get; set; }

    public decimal TotalAmount => Quantity * Product.Price;
}
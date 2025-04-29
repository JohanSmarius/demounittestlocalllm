using CommunityToolkit.Diagnostics;

public class Order
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount => Orderlines.Sum(ol => ol.TotalAmount);

    private List<Orderline> Orderlines { get; set; } = [];

    public IEnumerable<Orderline> GetOrderlines() => Orderlines.AsReadOnly();

    public void AddOrderline(Orderline orderline)
    {
        Guard.IsNotNull(orderline, nameof(orderline));
        
        Orderlines.Add(orderline);
    }



}
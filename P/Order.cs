namespace OOP.P;

public class Order
{
    public Customer Customer { get; set; }
    public double Total { get; set; }
    public int TotalQuantity { get; set; }
    public DateTime CreatedDate { get; set; }

}

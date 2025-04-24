namespace Cooker.Domain;

public class Order
{
    public Guid OrderId = Guid.NewGuid();
    public string? Name { get; set; }
    
    public int StatusId { get; set; }

}
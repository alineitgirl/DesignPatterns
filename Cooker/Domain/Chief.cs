namespace Cooker.Domain;

public class Chief : IChief
{
    public IDictionary<int, string> GetStatuses()
    {
        var orders = new Dictionary<int, string>();

        orders.Add(1, "ready");
        orders.Add(2, "not ready");
        orders.Add(3, "preparing");
        
        Thread.Sleep(2000);

        return orders;
    }

    public IEnumerable<Order> GetOrders()
    {
        var orders = new List<Order>();
        
        orders.Add(new Order {Name = "Burgher", StatusId = GetRandomStatusId});
        orders.Add(new Order {Name = "Pasta", StatusId = GetRandomStatusId});
        orders.Add(new Order {Name = "Pizza", StatusId = GetRandomStatusId});

        return orders;
    }

    private static int GetRandomStatusId => new Random().Next(1, 4);
}
namespace Cooker.Domain;

public interface IChief
{
    IDictionary<int, string> GetStatuses();
    IEnumerable<Order> GetOrders();
}
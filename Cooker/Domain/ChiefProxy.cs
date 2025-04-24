namespace Cooker.Domain;

public class ChiefProxy : IChief
{
    private readonly Chief _chief;
    private IDictionary<int, string>? _statuses = null;
    
    public ChiefProxy(Chief chief)
    {
        _chief = chief;
    }
    public IEnumerable<Order> GetOrders()
    {
        Console.WriteLine($"{DateTime.Now :g}\t\t GetOrders");
        return _chief.GetOrders();
    }

    public IDictionary<int, string> GetStatuses()
    {
        if (_statuses is null)
        {
            _statuses = _chief.GetStatuses();
        }

        return _statuses;
    }
}
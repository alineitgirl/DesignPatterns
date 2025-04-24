using Cooker.Domain;

namespace Cooker;

class Program
{
    static void Main()
    {
        var chief = new ChiefProxy(new Chief());

        while (true)
        {
            Thread.Sleep(2000);
            
            Console.Clear();

            Console.WriteLine("-------------Welcome to Cooker!\n\n\n");
            Console.WriteLine("\n\n\n----------------------------");

            var orders = chief.GetOrders();
            var statuses = chief.GetStatuses();

            foreach (var order in orders)
            {
                if (statuses.TryGetValue(order.StatusId, out var status))
                {
                    Console.WriteLine($"{order.Name}\t\t\t{status}");
                }
                else
                {
                    Console.WriteLine($"{order.Name}\t\t\t<unknown status>");
                }
            }
           
        }
    }
}

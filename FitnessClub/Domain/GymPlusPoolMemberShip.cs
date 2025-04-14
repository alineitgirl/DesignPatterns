namespace FitnessClub.Domain;

public class GymPlusPoolMemberShip : IMemberShip
{
    private readonly string _name;
    private readonly decimal _price;

    public GymPlusPoolMemberShip(decimal price)
    {
        _name = "Gym + Pool membership";
        _price = price;
    }
    public string Name => _name;
    
    public string Description { get; set; }
    
    public decimal GetPrice() => _price;
}
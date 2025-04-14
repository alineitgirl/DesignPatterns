using FitnessClub.Domain;

namespace FitnessClub.Factories;

public class GymPlusPoolMembershipFactory : IMembershipFactory
{
    private readonly decimal _price;
    private readonly string _description;

    public GymPlusPoolMembershipFactory(decimal price, string description)
    {
        _price = price;
        _description = description;
    }

    public override IMemberShip GetMembership()
    {
        var memberShip = new GymPlusPoolMemberShip(_price)
        {
            Description = _description
        };

        return memberShip;
    }
}
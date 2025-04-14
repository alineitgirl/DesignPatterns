using FitnessClub.Domain;

namespace FitnessClub.Factories;

public class PersonalTrainingMembershipFactory : IMembershipFactory
{
    private readonly decimal _price;
    private readonly string _description;

    public PersonalTrainingMembershipFactory(decimal price, string description)
    {
        _price = price;
        _description = description;
    }

    public override IMemberShip GetMembership()
    {
        var memberShip = new PersonalTrainingMembership(_price)
        {
            Description = _description
        };

        return memberShip;
    }
}
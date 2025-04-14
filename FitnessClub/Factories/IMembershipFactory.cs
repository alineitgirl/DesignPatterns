using FitnessClub.Domain;

namespace FitnessClub.Factories;

public abstract class  IMembershipFactory
{
    public abstract IMemberShip GetMembership();
}
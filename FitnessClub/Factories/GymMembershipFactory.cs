using FitnessClub.Domain;

namespace FitnessClub.Factories;

public class GymMembershipFactory : IMembershipFactory
{
   private readonly decimal _price;
   private readonly string _description;

   public GymMembershipFactory(decimal price, string description)
   {
      _price = price;
      _description = description;
   }

   public override IMemberShip GetMembership()
   {
      GymMemberShip memberShip = new GymMemberShip(_price)
      {
         Description = _description
      };

      return memberShip;
   }
}
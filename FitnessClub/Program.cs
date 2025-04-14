using System;
using System.IO;
using FitnessClub.Domain;
using FitnessClub.Factories;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>> Welcome to Fitness Club CRM <<<\n\n\n");

            Console.WriteLine("> Enter the type of membership you want to create: ");
            Console.WriteLine("G - Gym");
            Console.WriteLine("P - Gym + Pool");
            Console.WriteLine("T - Personal Training");

            var membershipType = Console.ReadLine();

            var factory = GetFactory(membershipType);
            var membership = factory.GetMembership();

            Console.WriteLine("\n\n> You 've just created new membership:");
            Console.WriteLine($"\t\t\tName: {membership.Name}\n" +
                              $"\t\t\tDescrption: {membership.Description}\n" +
                              $"\t\t\tPrice: {membership.GetPrice()}");

        }

        private static IMembershipFactory GetFactory(string membershipType) =>
            membershipType.ToLower() switch
            {
                "g" => new GymMembershipFactory(100, "Basic membership"),
                "p" => new GymPlusPoolMembershipFactory(250, "Gym + Pool membership"),
                "t" => new PersonalTrainingMembershipFactory(500, "Personal Training Membership"),
                _ => null
            };
    }
    
}


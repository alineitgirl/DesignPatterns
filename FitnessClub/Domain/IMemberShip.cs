namespace FitnessClub.Domain;

public interface IMemberShip
{ 
    string Name { get; }
    string Description { get; set; }

    decimal GetPrice();
}
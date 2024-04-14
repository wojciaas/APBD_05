using VetClinic_webApi_rest.Models;

namespace VetClinic_webApi_rest.Database;

public class MockDb
{
    public static readonly List<Animal> _animals = new()
    {
        new Animal("Rex", Animal.AnimalType.Dog, 5, Animal.Color.Brown),
        new Animal("Whiskers", Animal.AnimalType.Cat, 3, Animal.Color.White),
        new Animal("Fluffy", Animal.AnimalType.Bird, 1, Animal.Color.White),
        new Animal("Bubbles", Animal.AnimalType.Fish, 1, Animal.Color.White)
    };
    
    public static readonly List<Visit> _visits = new()
    {
        new Visit(_animals[0], "Annual checkup", 50),
        new Visit(_animals[1], "Vaccination", 30),
        new Visit(_animals[2], "Beak trimming", 20),
        new Visit(_animals[3], "Water quality check", 10),
        new Visit(_animals[0], "Dental cleaning", 100)
    };
}
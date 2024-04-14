using VetClinic_webApi_rest.Models;

namespace VetClinic_webApi_rest.Database;

public class MockDb
{
    public static readonly List<Animal> _animals = new()
    {
        new Animal("Rex", "Dog", 5, "Brown"),
        new Animal("Mittens", "Cat", 3, "White"),
        new Animal("Polly", "Bird", 1, "Green"),
        new Animal("Goldie", "Fish", 0.5, "Gold"),
        new Animal("Buddy", "Dog", 6, "Black"),
        new Animal("Whiskers", "Cat", 4, "Gray")
    };
    
    public static readonly List<Visit> _visits = new()
    {
        new Visit(_animals[0], "Annual checkup", 50),
        new Visit(_animals[1], "Vaccination", 30),
        new Visit(_animals[2], "Beak trimming", 20),
        new Visit(_animals[3], "Water quality check", 10),
        new Visit(_animals[0], "Dental cleaning", 100),
        new Visit(_animals[1], "Flea treatment", 40)
    };
}
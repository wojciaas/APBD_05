namespace VetClinic_webApi_rest.Models;

public class Visit
{
    private static int _nextId = 1;
    public int Id { get; } = _nextId++;
    public DateTime VisitDate { get; } = DateTime.Now;
    public Animal Animal { get; }
    public string? Description { get; set; }
    public double Cost { get; }
    
    public Visit(Animal animal, string? description, double cost)
    {
        Animal = animal;
        Description = description;
        Cost = cost;
    }
}
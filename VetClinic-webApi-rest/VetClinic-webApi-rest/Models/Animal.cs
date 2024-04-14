using System.Runtime.Serialization;

namespace VetClinic_webApi_rest.Models;

public class Animal
{
    private static int _nextId = 1;
    public int Id { get; } = _nextId++;
    public string Name { get; set; }
    public string Category { get; set; }
    public double Weight { get; set; }
    public string FurColor { get; set; }
    
    public Animal(string name, string category, double weight, string furColor)
    {
        Name = name;
        Category = category;
        Weight = weight;
        FurColor = furColor;
    }
}
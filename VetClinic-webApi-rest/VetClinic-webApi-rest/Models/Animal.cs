using System.Runtime.Serialization;

namespace VetClinic_webApi_rest.Models;

public class Animal
{
    public enum AnimalType
    {
        [EnumMember(Value = "Dog")]
        Dog,
        [EnumMember(Value = "Cat")]
        Cat,
        [EnumMember(Value = "Bird")]
        Bird,
        [EnumMember(Value = "Fish")]
        Fish
    }
    
    public enum Color
    {
        [EnumMember(Value = "Black")]
        Black,
        [EnumMember(Value = "White")]
        White,
        [EnumMember(Value = "Brown")]
        Brown,
        [EnumMember(Value = "Gray")]
        Gray
    }
    
    
    private static int _nextId = 1;
    public int Id { get; } = _nextId++;
    public string Name { get; set; }
    public AnimalType Category { get; set; }
    public double Weight { get; set; }
    public Color FurColor { get; set; }
    
    public Animal(string name, AnimalType category, double weight, Color furColor)
    {
        Name = name;
        Category = category;
        Weight = weight;
        FurColor = furColor;
    }
}
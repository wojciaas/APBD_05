using Microsoft.AspNetCore.Mvc;
using VetClinic_webApi_rest.Database;
using VetClinic_webApi_rest.Models;

namespace VetClinic_webApi_rest.Controllers;

[Route("api/animals")]
[ApiController]
public class AnimalsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok(MockDb._animals);
    }
    
    [HttpGet("{id:int}")]
    public IActionResult GetAnimal(int id)
    {
        var animal = MockDb._animals.FirstOrDefault(a => a.Id == id);
        if (animal == null)
        {
            return NotFound($"Animal with id {id} not found.");
        }
        return Ok(animal);
    }

    [HttpPost]
    public IActionResult CreateAnimal(Animal animal)
    {
        MockDb._animals.Add(animal);
        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateAnimal(int id, Animal animal)
    {
        var animalToEdit = MockDb._animals.FirstOrDefault(a => a.Id == id);
        if (animalToEdit == null)
        {
            return NotFound($"Animal with id {id} not found.");
        }
        animalToEdit.Name = animal.Name;
        animalToEdit.Category = animal.Category;
        animalToEdit.Weight = animal.Weight;
        animalToEdit.FurColor = animal.FurColor;
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animalToDelete = MockDb._animals.FirstOrDefault(a => a.Id == id);
        if (animalToDelete == null)
        {
            return NotFound($"Animal with id {id} not found.");
        }
        MockDb._animals.Remove(animalToDelete);
        return NoContent();
    }
}
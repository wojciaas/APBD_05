using Microsoft.AspNetCore.Mvc;
using VetClinic_webApi_rest.Database;
using VetClinic_webApi_rest.Models;

namespace VetClinic_webApi_rest.Controllers;

[Route("api/visits")]
[ApiController]
public class VisitController : ControllerBase
{
    [HttpGet]
    public IActionResult GetVisits()
    {
        return Ok(MockDb._visits);
    }
    
    [HttpGet("{id:int}")]
    public IActionResult GetVisit(int id)
    {
        var visit = MockDb._visits.FirstOrDefault(v => v.Id == id);
        if (visit == null)
        {
            return NotFound($"Visit with id {id} not found.");
        }
        return Ok(visit);
    }
    
    [HttpGet("animal/{animalId:int}")]
    public IActionResult GetVisitsByAnimal(int animalId)
    {
        var visits = MockDb._visits.Where(v => v.Animal.Id == animalId);
        if (!visits.Any())
        {
            return NotFound($"No visits found for animal with id {animalId}.");
        }
        return Ok(visits);
    }
    
    [HttpPost]
    public IActionResult CreateVisit(int animalId, [FromBody] string? description, double cost)
    {
        var animal = MockDb._animals.FirstOrDefault(a => a.Id == animalId);
        if (animal == null)
        {
            return NotFound($"Animal with id {animalId} not found.");
        }
        MockDb._visits.Add(new Visit(animal, description, cost));
        return StatusCode(StatusCodes.Status201Created);
    }
}
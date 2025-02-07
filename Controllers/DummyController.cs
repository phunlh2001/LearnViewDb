using Microsoft.AspNetCore.Mvc;
using TestViewDb.Models;

namespace TestViewDb.Controllers;
[Route("api/dummy")]
[ApiController]
public class DummyController : ControllerBase
{
    [HttpPost("add")]
    public IActionResult Add()
    {
        using var _db = new AppDbContext();
        var prod = new Car
        {
            Id = Guid.NewGuid(),
            Category = "BMW",
            House = "134 LA"
        };
        _db.Cars.Add(prod);

        var person = new Person
        {
            Id = Guid.NewGuid(),
            Name = "Kaiz",
            House = "134 LA"
        };
        _db.People.Add(person);

        _db.SaveChanges();
        return Ok();
    }

    [HttpGet("all")]
    public IActionResult GetAll()
    {
        using var _db = new AppDbContext();
        var list = _db.VwPersonCars.ToList();
        return Ok(list);
    }
}

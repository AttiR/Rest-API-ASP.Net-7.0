using AynaCar.Contracts.Car;
using Microsoft.AspNetCore.Mvc;

namespace AynaCar.Coontrollers;

[ApiController]

public class CarContoller : ControllerBase
{
    // Endpoint to create a new car
    [HttpPost("/cars")]

    public IActionResult CreateCar(CreateCarRequest request)
    {
        return Ok(request);
    }

    // Endpoint to get a Car by id
    [HttpGet("/cars/{id:guid}")]
    public IActionResult GetCar(Guid id)
    {
        return Ok(id);
    }

    // Endpoint to put a Car
    [HttpPut("{id:guid}")]
    public IActionResult UpsertBreakfast(Guid id, UpsertCarRequest request)
    {
        return Ok(request);
    }

    // Endpoint to Delte a Car by id
    [HttpDelete("/cars/{id:guid}")]
    public IActionResult DeleteCar(Guid id)
    {
        return Ok(id);
    }
}

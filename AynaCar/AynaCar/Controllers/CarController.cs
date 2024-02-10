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

    // Endpoint to get a car by its ID
    [HttpGet("/cars/{id: guid}")]

    public IActionResult GetCar(Guid id)
    {
        return Ok(id);
    }

    // Endpoint to update or insert a car
    [HttpPut("/cars/{id: guid}")]

    public IActionResult UpsertCar(Guid id, UpsertCarRequest request)
    {
        return Ok(request);
    }

    // Endpoint to delete a car by its ID
    [HttpDelete("/cars/{id: guid}")]

    public IActionResult DeleteCar(Guid id)
    {
        return Ok(id);
    }
}

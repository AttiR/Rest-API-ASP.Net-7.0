using AynaCar.Contracts.Car;
using AynaCar.Models;
using AynaCar.Services.Cars;
using Microsoft.AspNetCore.Mvc;

namespace AynaCar.Coontrollers;

[ApiController]
[Route("[Controller]")]

public class CarContoller : ControllerBase
{

    private readonly ICarService _carService;

    [HttpPost]

    public IActionResult CreateCar(CreateCarRequest request)
    {
        var car = new Car(
           Guid.NewGuid(),
           request.Brand,
           request.Model,
           request.Year,
           request.Color,
           request.Price,
           DateTime.UtcNow
           );

        _carService.CreateCar(car);
        // Save car to database
        // taking the data from the system and converting it back to API definition
        var response = new CarResponse(
            car.Id,
            car.Brand,
            car.Model,
            car.Year,
            car.Color,
            car.Price,
            car.LastModifiedDateTime
        );

        return CreatedAtAction(
            actionName: nameof(GetCar),
            routeValues: new { id = car.Id },
            value:response);
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

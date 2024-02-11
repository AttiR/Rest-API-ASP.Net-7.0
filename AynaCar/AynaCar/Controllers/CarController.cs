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

}

using AynaCar.Models;

namespace AynaCar.Services.Cars;

public class CarService : ICarService
{
    private static readonly Dictionary<Guid, Car> _cars = new();
    public void CreateCar(Car car)
    {
        _cars.Add(car.Id, car);
    }
}

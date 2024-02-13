namespace AynaCar.Models;

public  class Car
{
    public Guid Id { get; }
    public string Brand { get; }
    public string Model { get; }
    public int Year { get; }
    public string Color { get; }
    public decimal Price { get; }
    public DateTime LastModifiedDateTime { get; }

    public Car(
        Guid id,
        string brand,
        string model,
        int year,
        string color,
        decimal price,
        DateTime lastModifiedDateTime)
    {
        // Enforce variants
        Id = id;
        Brand = brand;
        Model = model;
        Year = year;
        Color = color;
        Price = price;
        LastModifiedDateTime = lastModifiedDateTime;
    }
}

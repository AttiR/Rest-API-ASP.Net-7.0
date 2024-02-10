namespace AynaCar.Contracts.Car;
public record CarResponse
(
    Guid Id,
    string Brand,
    string Model,
    int Year,
    string Color,
    decimal Price
);

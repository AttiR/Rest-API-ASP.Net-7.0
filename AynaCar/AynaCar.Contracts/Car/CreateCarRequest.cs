namespace AynaCar.Contracts.Car;

public record CreateCarRequest
(
    string Brand,
    string Model,
    int Year,
    string Color,
    decimal Price
);

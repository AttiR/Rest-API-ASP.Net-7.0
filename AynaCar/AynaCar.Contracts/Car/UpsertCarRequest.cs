namespace AynaCar.Contracts.Car;
public record UpsertCarRequest
(
    string Brand,
    string Model,
    int Year,
    string Color,
    decimal Price
);

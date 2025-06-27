namespace VehiculosYa.Vehicles.Domain.Models;

public class Vehicle
{
    public Guid Id { get; set; }
    public required  string Plate { get; set; }
    public required  string Brand { get; set; }
    public required  string Model { get; set; }
    public required int Kms { get; set; }
}
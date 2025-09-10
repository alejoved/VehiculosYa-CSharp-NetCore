namespace VehiculosYa.Maintenances.Domain.Models;
public class Maintenance
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public string Type { get; set; }
    public string Description { get; set; }
    public string Cost { get; set; }
}
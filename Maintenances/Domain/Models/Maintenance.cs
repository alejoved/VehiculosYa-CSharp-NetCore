namespace VehiculosYa.Maintenances.Domain.Models;
public class Maintenance
{
    //maintenance: id, date, description, cost
    public Guid Id { get; set; }
    public string Date { get; set; }
    public string Type { get; set; }
    public double Description { get; set; }
    public string Cost { get; set; }
}
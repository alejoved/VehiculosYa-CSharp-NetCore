
namespace VehiculosYa.Penalties.Domain.Models;
public class Penalty
{
    public Guid Id { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
    public double Amount { get; set; }
    public string Status { get; set; }
}
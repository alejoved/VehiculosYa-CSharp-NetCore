
namespace VehiculosYa.Securities.Domain.Models;
public class Security
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
    public double Cost { get; set; }
    public string Status { get; set; }
}
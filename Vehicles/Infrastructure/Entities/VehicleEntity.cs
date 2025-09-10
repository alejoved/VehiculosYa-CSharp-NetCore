using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehiculosYa.Vehicles.infrastructure.Entities
{
    [Table("vehicle")]
    public class VehicleEntity
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Plate { get; set; } = string.Empty;
        [Required]
        public string Brand { get; set; } = string.Empty;
        [Required]
        public string Model { get; set; } = string.Empty;
        [Required]
        public int Kms { get; set; }
    }
}
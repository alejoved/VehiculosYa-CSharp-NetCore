using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehiculosYa.Maintenances.infrastructure.Entities
{
    [Table("maintenance")]
    public class MaintenanceEntity
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Cost { get; set; }
    }
}
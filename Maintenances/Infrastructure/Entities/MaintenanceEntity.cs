using System.ComponentModel.DataAnnotations;

namespace VehiculosYa.Maintenances.infrastructure.Entities
{
    public class MaintenanceEntity
    {
        //maintenance: id, date, description, cost
        [Key]
        public Guid Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public double Description { get; set; }
        [Required]
        public string Cost { get; set; }
    }
}
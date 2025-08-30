using System.ComponentModel.DataAnnotations;

namespace VehiculosYa.Securities.infrastructure.Entities
{
    public class PenaltyEntity
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public string Status { get; set; }
    }
}
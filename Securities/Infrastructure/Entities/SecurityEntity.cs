using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehiculosYa.Securities.infrastructure.Entities
{
    [Table("security")]
    public class SecurityEntity
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
        public double Cost { get; set; }
        [Required]
        public string Status { get; set; }
    }
}
namespace VehiculosYa.Maintenances.Interface.Rest.Dtos
{
    public class MaintenanceUpdateDto
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Cost { get; set; }
    }
}
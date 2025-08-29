namespace VehiculosYa.Securities.Interface.Rest.Dtos
{
    public class SecurityDto
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int Cost { get; set; }
        public string Status { get; set;}
    }
}
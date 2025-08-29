namespace VehiculosYa.Securities.Interface.Rest.Dtos
{
    public class SecurityResponseDto
    {
        public Guid Id { get;  set;}
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
    }
}
namespace VehiculosYa.Penalties.Interface.Rest.Dtos
{
    public class PenaltyUpdateDto
    {
        public string Description { get; set; }
        public string Type { get; set; }
        public double Amount { get; set; }
        public string Status { get; set; }
    }
}
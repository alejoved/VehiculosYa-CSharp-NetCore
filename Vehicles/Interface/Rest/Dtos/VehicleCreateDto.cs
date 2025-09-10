namespace VehiculosYa.Vehicles.Interface.Rest.Dtos
{
    public class VehicleCreateDto
    {
        public string Plate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Kms { get; set;}
    }
}
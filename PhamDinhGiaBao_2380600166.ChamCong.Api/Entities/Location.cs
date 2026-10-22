namespace PhamDinhGiaBao_2380600166.ChamCong.Api.Entities;

public class Location
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public double Lat { get; set; }
    public double Lng { get; set; }
    public int RadiusMeters { get; set; } = 100;
}

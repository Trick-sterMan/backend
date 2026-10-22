namespace PhamDinhGiaBao_2380600166.ChamCong.Api.Entities;

public class Shift
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
}

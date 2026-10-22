namespace PhamDinhGiaBao_2380600166.ChamCong.Api.Entities;

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int? ManagerId { get; set; }
    public User? Manager { get; set; }
}

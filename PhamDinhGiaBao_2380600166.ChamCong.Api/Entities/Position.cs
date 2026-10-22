namespace PhamDinhGiaBao_2380600166.ChamCong.Api.Entities;

public class Position
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    /// <summary>Nhóm role được giữ chức vụ này (Manager hoặc Employee).</summary>
    public Role RoleGroup { get; set; }
}

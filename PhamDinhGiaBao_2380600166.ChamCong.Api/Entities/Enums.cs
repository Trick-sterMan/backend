namespace PhamDinhGiaBao_2380600166.ChamCong.Api.Entities;

public enum Role { Admin, Manager, Employee }

public enum UserStatus { Pending, Active, Locked }

public enum OtpChannel { Email, Sms }

public enum OtpPurpose { Register, Login, AddContact }

public enum AttendanceStatus { OnTime, Late, PendingReview, Rejected }

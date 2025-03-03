namespace Pizza4Ps.StaffService.Domain.Enums
{
    public enum ShiftRegistrationEnum
    {
        Registered, // đã đăng ký lịch rảnh
        Waiting, // đăng ký vào slot đã đủ người hoặc đăng ký thêm nên vô hàng chờ
        Approved // manager đã duyệt
    }
}

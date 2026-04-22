using System;
using System.Collections.Generic;

namespace QuanLyKhachSan.Models;

public partial class ThanhToan
{
    public int MaThanhToan { get; set; }

    public int MaHoaDon { get; set; }

    public decimal SoTien { get; set; }

    public string PhuongThuc { get; set; } = null!;

    public DateTime ThoiDiemThanhToan { get; set; }

    public string? MaThamChieu { get; set; }

    public virtual HoaDon MaHoaDonNavigation { get; set; } = null!;
}

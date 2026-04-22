using System;
using System.Collections.Generic;

namespace QuanLyKhachSan.Models;

public partial class TaiKhoan
{
    public int MaTaiKhoan { get; set; }

    public string TenDangNhap { get; set; } = null!;

    public string MatKhauHash { get; set; } = null!;

    public string HoTenHienThi { get; set; } = null!;

    public string? Email { get; set; }

    public string? SoDienThoai { get; set; }

    public string VaiTro { get; set; } = null!;

    public string TrangThai { get; set; } = null!;

    public DateTime? LanDangNhapCuoi { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime NgayCapNhat { get; set; }
}

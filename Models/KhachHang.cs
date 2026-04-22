using System;
using System.Collections.Generic;

namespace QuanLyKhachSan.Models;

public partial class KhachHang
{
    public int MaKhachHang { get; set; }

    public string HoTen { get; set; } = null!;

    public string SoDienThoai { get; set; } = null!;

    public string? Email { get; set; }

    public string SoGiayTo { get; set; } = null!;

    public string? QuocTich { get; set; }

    public DateTime NgayTao { get; set; }

    public virtual ICollection<DatPhong> DatPhongs { get; set; } = new List<DatPhong>();
}
